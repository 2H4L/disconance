namespace Disconance.Http.Tests;

internal sealed class ManualTimeProvider : TimeProvider
{
    private readonly Lock _sync = new();
    private readonly List<ManualTimer> _timers = [];
    private TaskCompletionSource _delayScheduled = new(TaskCreationOptions.RunContinuationsAsynchronously);
    private DateTimeOffset _now = DateTimeOffset.UnixEpoch;

    public override long TimestampFrequency => TimeSpan.TicksPerSecond;

    internal Task DelayScheduled => _delayScheduled.Task;

    public override DateTimeOffset GetUtcNow()
    {
        lock (_sync)
        {
            return _now;
        }
    }

    public override long GetTimestamp()
    {
        return GetUtcNow().Ticks;
    }

    internal void ResetObserver()
    {
        _delayScheduled = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
    }

    public override ITimer CreateTimer(TimerCallback callback, object? state, TimeSpan dueTime, TimeSpan period)
    {
        var timer = new ManualTimer(this, callback, state);

        lock (_sync)
        {
            _timers.Add(timer);
        }

        timer.Change(dueTime, period);
        return timer;
    }

    internal void Advance(TimeSpan elapsed)
    {
        List<ManualTimer> due;

        lock (_sync)
        {
            _now += elapsed;
            due = _timers.Where(t => !t.Disposed && t.Due <= _now).ToList();

            foreach (var timer in due)
            {
                timer.Due = timer.Period == Timeout.InfiniteTimeSpan ? DateTimeOffset.MaxValue : _now + timer.Period;
            }
        }

        foreach (var timer in due)
        {
            timer.Fire();
        }
    }

    private sealed class ManualTimer(ManualTimeProvider owner, TimerCallback callback, object? state) : ITimer
    {
        internal bool Disposed;
        internal DateTimeOffset Due = DateTimeOffset.MaxValue;
        internal TimeSpan Period;

        public bool Change(TimeSpan dueTime, TimeSpan period)
        {
            lock (owner._sync)
            {
                if (Disposed)
                {
                    return false;
                }

                Due = dueTime == Timeout.InfiniteTimeSpan ? DateTimeOffset.MaxValue : owner._now + dueTime;
                Period = period;

                if (dueTime >= TimeSpan.Zero && dueTime < TimeSpan.FromSeconds(10))
                {
                    owner._delayScheduled.TrySetResult();
                }

                return true;
            }
        }

        public void Dispose()
        {
            lock (owner._sync)
            {
                Disposed = true;
            }
        }

        public ValueTask DisposeAsync()
        {
            Dispose();
            return ValueTask.CompletedTask;
        }

        internal void Fire()
        {
            callback(state);
        }
    }
}