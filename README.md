# Disconance

Disconance is a C# framework for building Discord bots. It provides typed Discord API models, a fluent HTTP client, and interaction handling for ASP.NET Core.

Build messages with fluent builders, handle commands and components with scoped services, and integrate with .NET dependency injection.

## Packages

| Package | Purpose |
| --- | --- |
| [Disconance.Models](https://www.nuget.org/packages/Disconance.Models) | Discord API models and System.Text.Json serialization. |
| [Disconance.Http](https://www.nuget.org/packages/Disconance.Http) | HTTP requests, fluent builders, file uploads, and rate limiting. |
| [Disconance.Interactions](https://www.nuget.org/packages/Disconance.Interactions) | Commands, components, modals, middleware, and signed ASP.NET Core endpoints. |

Each package includes its required dependencies. Models and HTTP can also be used independently of the interaction framework.

## Getting started

### Create the application

Use an ASP.NET Core project targeting .NET 10. For a new application:

```sh
dotnet new web --name MyDiscordBot --framework net10.0
cd MyDiscordBot
dotnet add package Disconance.Interactions --prerelease
```

Create a Discord application in the [Developer Portal](https://discord.com/developers/applications). Copy its Application ID and Public Key from **General Information**, and its token from **Bot**.

Add the non-secret settings to `appsettings.json`:

```json
{
  "Discord": {
    "ApplicationId": "YOUR_APPLICATION_ID",
    "PublicKey": "YOUR_PUBLIC_KEY"
  }
}
```

Store the bot token in [user secrets](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-10.0) for local development:

```sh
dotnet user-secrets init
dotnet user-secrets set "Discord:BotToken" "YOUR_BOT_TOKEN"
```

ASP.NET Core loads user secrets in the Development environment. For deployment, supply the token through your secret configuration provider or the `Discord__BotToken` environment variable.

### Define a command

Create `PingCommand.cs`. `Configure` defines the slash command; `ExecuteAsync` handles it and returns the initial response.

```csharp
using Disconance.Http.Builders.Commands;
using Disconance.Http.Builders.Interactions;
using Disconance.Interactions.Commands;
using Disconance.Models.Interactions;

public sealed class PingCommand : Command
{
    public override void Configure(ApplicationCommandDefinitionBuilder command)
    {
        command.WithName("ping").WithDescription("Replies with Pong!");
    }

    public override Task<InteractionResponse> ExecuteAsync(CommandContext context,
        CancellationToken cancellationToken = default)
    {
        var response = new InteractionResponseBuilder()
            .WithMessage(message => message.WithContent("Pong!"))
            .Build();

        return Task.FromResult(response);
    }
}
```

Commands are scoped services and support constructor injection. `CommandContext` provides the interaction, command data, and supplied options.

### Configure the endpoint

Replace `Program.cs` with:

```csharp
using Disconance.Interactions.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddDisconanceInteractions()
    .AddInteraction<PingCommand>()
    .RegisterGlobalCommandsOnStartup();

var app = builder.Build();
app.MapDisconanceInteractions("/discord/interactions");

await app.RunAsync();
```

`AddDisconanceInteractions()` reads the `Discord` configuration section, converts the application ID, and registers the HTTP client. Discord JSON serialization is configured for HTTP requests and the interaction endpoint. Use `AddDisconanceInteractions("MyBot")` for a different section; optional transport settings belong in its `Http` child section.

`MapDisconanceInteractions` verifies Discord signatures, answers validation pings, and dispatches interactions to your handlers. In an existing API application, add the same service registrations and endpoint mapping.

For assembly discovery, replace `AddInteraction<PingCommand>()` with `AddInteractionsFromAssembly(typeof(PingCommand).Assembly)`; discovered handlers must be public concrete classes.

### Register commands

`AddInteraction` registers your handler for local dispatch. `RegisterGlobalCommandsOnStartup` publishes the discovered command definitions to Discord before the application starts serving requests. It creates or updates commands without deleting other commands; registration failures stop startup.

For a test server, omit the global registration call and add this before `builder.Build()`. Replace the example server ID with one copied using Discord's Developer Mode:

```csharp
builder.Services.RegisterGuildCommandsOnStartup(123456789012345678UL);
```

The application ID comes from configuration. Repeat guild registration for additional servers, or combine it with global registration. Duplicate targets are registered once per startup. A guild ID is only needed when selecting a guild target.

Guild commands update immediately; global commands are available across installations. See [Discord's command registration guide](https://docs.discord.com/developers/interactions/application-commands#registering-a-command). Omit the startup registration calls to manage publishing separately through `ICommandRegistrationService` or the HTTP fluent API.

### Connect Discord

Start the application:

```sh
dotnet run -- --urls http://localhost:5000
```

Expose the running application through a public HTTPS URL, using a tunnel for local development or your deployed API's address. In the Developer Portal, set **Interactions Endpoint URL** to `https://YOUR_HOST/discord/interactions`. Disconance handles Discord's endpoint validation. See [Discord's endpoint setup guide](https://docs.discord.com/developers/interactions/overview#configuring-an-interactions-endpoint-url).

Install the application into your test server with the `applications.commands` scope, then run `/ping`. The `bot` scope includes `applications.commands` automatically.

## More interactions

- Organize slash commands with `CommandGroup`, `Subcommand<TParent>`, and `SubcommandGroup<TParent>`; override `AutocompleteAsync` for autocomplete responses.
- Implement `IMessageComponentHandler` or `IModalSubmitHandler`, match custom IDs in `CanHandle`, and register with `AddInteraction<T>()`.
- Implement `IInteractionMiddleware` and register with `AddInteractionMiddleware<T>()`; middleware runs in registration order.

Return an initial response within Discord's three-second deadline. For longer operations, queue the work, return `new InteractionResponseBuilder().Defer().Build()`, and edit the original response through the HTTP interaction webhook API when the work finishes. See [Discord's response lifecycle](https://docs.discord.com/developers/interactions/receiving-and-responding#responding-to-an-interaction).

## License

[MIT](https://github.com/2H4L/disconance/blob/main/LICENSE).
