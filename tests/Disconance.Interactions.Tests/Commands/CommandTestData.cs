using Disconance.Http.Builders.Commands;
using Disconance.Http.Builders.Interactions.Commands;
using Disconance.Interactions.Commands;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Interactions.Tests.Commands;

internal static class CommandTestData
{
    internal static Interaction Interaction(InteractionType type = InteractionType.ApplicationCommand,
        ApplicationCommandData? data = null)
    {
        return new Interaction
        {
            Id = 1, ApplicationId = 2, Type = type, Token = "token", Version = 1,
            AppPermissions = 0, Entitlements = [], AuthorizingIntegrationOwners = [], AttachmentSizeLimit = 1024,
            Data = data ?? Data()
        };
    }

    internal static ApplicationCommandData Data(string name = "admin",
        params ApplicationCommandInteractionDataOption[] options)
    {
        return new ApplicationCommandData
            { Id = 3, Name = name, Type = ApplicationCommandType.ChatInput, Options = options.ToList() };
    }

    internal static ApplicationCommandInteractionDataOption Nested(string name, ApplicationCommandOptionType type,
        params ApplicationCommandInteractionDataOption[] options)
    {
        return new ApplicationCommandInteractionDataOption { Name = name, Type = type, Options = options.ToList() };
    }

    internal static InteractionResponse Response(string content)
    {
        return new InteractionResponse
        {
            Type = InteractionCallbackType.ChannelMessageWithSource,
            Data = new InteractionMessageData { Content = content }
        };
    }

    internal sealed class Ping(ApplicationCommandType type = ApplicationCommandType.ChatInput) : Command
    {
        public CommandContext? Received { get; private set; }

        public CancellationToken Cancellation { get; private set; }

        public override void Configure(ApplicationCommandDefinitionBuilder command)
        {
            command.WithName("ping").WithType(type);

            if (type == ApplicationCommandType.ChatInput)
            {
                command.WithDescription("Replies with pong.");
            }
        }

        public override Task<InteractionResponse> ExecuteAsync(CommandContext context,
            CancellationToken cancellationToken = default)
        {
            Received = context;
            Cancellation = cancellationToken;
            return Task.FromResult(Response("pong"));
        }
    }

    internal sealed class Admin : CommandGroup
    {
        public override void Configure(ApplicationCommandDefinitionBuilder group)
        {
            group.WithName("admin").WithDescription("Administration.");
        }
    }

    internal sealed class Users : SubcommandGroup<Admin>
    {
        public override void Configure(ApplicationCommandOptionBuilder group)
        {
            group.WithName("users").WithDescription("Manage users.");
        }
    }

    internal sealed class Ban : Subcommand<Users>
    {
        public CommandContext? Received { get; private set; }

        public override void Configure(ApplicationCommandOptionBuilder command)
        {
            command.WithName("ban").WithDescription("Ban a user.")
                .AddOption(option => option.WithName("reason").WithDescription("Reason.")
                    .WithType(ApplicationCommandOptionType.String).WithAutocomplete(true));
        }

        public override Task<InteractionResponse> ExecuteAsync(CommandContext context,
            CancellationToken cancellationToken = default)
        {
            Received = context;
            return Task.FromResult(Response("banned"));
        }

        public override Task<InteractionResponse> AutocompleteAsync(CommandContext context,
            CancellationToken cancellationToken = default)
        {
            Received = context;

            return Task.FromResult(new InteractionResponse
            {
                Type = InteractionCallbackType.ApplicationCommandAutocompleteResult,
                Data = new InteractionAutocompleteData { Choices = [] }
            });
        }
    }

    internal sealed class Status : Subcommand<Admin>
    {
        public override void Configure(ApplicationCommandOptionBuilder command)
        {
            command.WithName("status").WithDescription("Show status.");
        }

        public override Task<InteractionResponse> ExecuteAsync(CommandContext context,
            CancellationToken cancellationToken = default)
        {
            return Task.FromResult(Response("ready"));
        }
    }
}