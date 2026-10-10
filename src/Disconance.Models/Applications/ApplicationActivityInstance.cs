namespace Disconance.Models.Applications;

/// <summary>
///     Activity Instance data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/application#get-application-activity-instance" />
public class ApplicationActivityInstance
{
    /// <summary>
    ///     Application ID.
    /// </summary>
    /// <remarks>Discord field: <c>application_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application#get-application-activity-instance" />
    public required Snowflake ApplicationId { get; set; }

    /// <summary>
    ///     Activity Instance ID.
    /// </summary>
    /// <remarks>Discord field: <c>instance_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application#get-application-activity-instance" />
    public required string InstanceId { get; set; }

    /// <summary>
    ///     Unique identifier for the launch.
    /// </summary>
    /// <remarks>Discord field: <c>launch_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application#get-application-activity-instance" />
    public required Snowflake LaunchId { get; set; }

    /// <summary>
    ///     Location the instance is running in.
    /// </summary>
    /// <remarks>Discord field: <c>location</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application#get-application-activity-instance" />
    public required ApplicationActivityLocation Location { get; set; }

    /// <summary>
    ///     IDs of the Users currently connected to the instance.
    /// </summary>
    /// <remarks>Discord field: <c>users</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/application#get-application-activity-instance" />
    public required List<Snowflake> Users { get; set; }
}