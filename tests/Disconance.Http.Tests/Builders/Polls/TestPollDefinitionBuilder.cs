using Disconance.Http.Builders.Polls;

namespace Disconance.Http.Tests.Builders.Polls;

public class TestPollDefinitionBuilder
{
    [Fact]
    public void Build_NestedPoll_ComposesQuestionAndAnswers()
    {
        var sut = new PollDefinitionBuilder()
            .WithQuestion(question => question.WithText("Ready?"))
            .AddAnswer(answer => answer.WithPollMedia(media => media.WithText("Yes")))
            .AddAnswer(answer => answer.WithPollMedia(media => media.WithText("No")))
            .WithAllowMultiselect(false);

        var result = sut.Build();

        Assert.Equal("Ready?", result.Question.Text.Value);
        Assert.Equal(2, result.Answers.Count);
        Assert.False(result.AllowMultiselect.Value);
        Assert.False(result.Duration.HasValue);
    }
}