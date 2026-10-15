using Disconance.Models;

namespace Disconance.Interactions.Hosting;

internal sealed record CommandRegistrationTarget(Snowflake? ApplicationId, Snowflake? GuildId);
