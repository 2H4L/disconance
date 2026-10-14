# Project notes

Disconance is a .NET framework for Discord bots. `Disconance.Models` and `Disconance.Http` target .NET 10. Models has no runtime NuGet dependencies; HTTP references Models and Microsoft.Extensions.Options for options and dependency injection integration.

## Model conventions

- Use mutable POCOs with `get; set;`. Use C# `required` for fields required by a full resource. Document length limits and contextual rules instead of enforcing them in setters.
- Use `Optional<T>` for fields Discord may omit and `Optional<T?>` when a field may also be explicitly null. A default optional is absent; an assigned value is present. Accessing an absent `Value` throws. Required nullable fields use `T?` directly.
- Keep named partial resources separate from full resources, with every field optional. Their available fields depend on the source context.
- Use `Snowflake` for Discord snowflake IDs, preserving the unsigned 64-bit range and invariant parsing. Keep other identifiers in their documented types, such as integer poll answer and component IDs or string integration account IDs.
- Use `DateTimeOffset` for ISO 8601 timestamps and `long` for documented Unix millisecond values.
- Preserve Discord's numeric enum values. Use `[Flags]` with a `ulong` backing type for bitfields, including permissions transmitted as decimal strings. Keep unknown numeric values representable.
- Keep open string vocabularies as strings with static classes of documented constants, rather than enums.
- Retain legacy fields and deprecated structures while Discord still documents them. Record deprecation in XML comments without adding compiler warnings for receiving older data.
- Use explicit variants for components, submitted component values, interaction data, message interaction metadata, profile fields, command scalar values, activity buttons, and message nonces. Concrete component classes fix their discriminators. Keep submitted values separate from display configuration.
- Keep poll composition (`PollDefinition`, `PollAnswerDefinition`) separate from returned resources (`Poll`, `PollAnswer`), whose answer IDs Discord assigns. Likewise, distinguish received activity button labels from supplied button objects.
- Identify team owners through `Team.OwnerUserId`; do not invent an owner role string.
- Use optional fields for context-dependent audit entry options and auto moderation metadata. Use `DiscordNull` for literal null in presence-only role tags.
- Reserve `object` for genuinely open schemas: audit change values and application-defined identity profile metadata. Preserve typed command choice and option variants; use `double` for numeric option bounds.

## Boundary with future libraries

- Keep `Disconance.Models` independent of HTTP transport. Shared System.Text.Json configuration lives in `Disconance.Models.Serialization`; use `DiscordJson.CreateOptions()` for Discord field names, optional omission, snowflake and permission encodings, null markers, and polymorphic dispatch. Unconfigured JSON serialization is unsupported.
- Keep POCOs mutable and attribute-free. Composition builders and their snapshot helpers belong in HTTP, alongside the rest of the fluent API.
- Include shared data structures such as interaction responses, poll definitions, voice states, and activities.
- Keep network clients, dependency injection, endpoint request classes, pagination envelopes, access-token exchanges, rate-limit objects, Gateway event envelopes, opcodes, connection handling, dispatch logic, and voice connection protocol messages outside Models.
- SDK-specific, RPC-specific, and undocumented objects are outside this library's scope.

## HTTP conventions

- Keep `Disconance.Http` usable without hosting or Interactions. Interactions always depends on HTTP and Models; neither depends on Interactions.
- All builders live in `Disconance.Http.Builders`, including nested model composition, request builders, shared contracts, and snapshot helpers. Builders check required values and structural conflicts and produce independent snapshots.
- Expose explicit typed requests through `IDiscordRequest<T>` and send through `IDiscordRequestSender`. Keep routes, query parameters, authentication, uploads, and payloads separate. Do not infer requests from reflected properties or register per-endpoint handlers.
- General Discord API POCOs and reusable composition definitions, including `ApplicationCommandDefinition`, belong in Models. Endpoint requests and bodies specific to create/edit operations belong in HTTP. A model's use as a request payload alone does not make it HTTP-specific. Reuse shared composition models instead of serializing returned resources as request bodies.
- Fluent scopes are extensions on the sender. Request builders are created through fluent scopes with a required sender and internal constructors; expose `Build()` and one `SendAsync(CancellationToken)` method. Model composition builders expose `Build()`. `With` replaces, `Add` appends, `Omit` restores absence, and explicit null clears nullable fields.
- Keep the MVP API focused: do not add alternate sender overloads, duplicate payload `Configure` wrappers, unsupported endpoint helpers, or public implementation utilities. Extend request handling through `IDiscordRequestSender` implementations and decorators.
- Expose only `DiscordHttpClient(DiscordHttpOptions)` publicly. The client owns and configures its transport; handler and clock substitution are internal test seams.
- Provide application setup through `AddDisconanceHttp` with an options callback. Register `IDiscordRequestSender` as a singleton without replacing existing implementations; consumers extend behavior through implementations and decorators. Snapshot configured options when creating the client.
- Reuse one HTTP client per credential. Coordinate learned rate-limit buckets independently; retry only 429 responses, with fresh content and streams per attempt. Keep tests deterministic using fake handlers and controlled time.

## Unit tests

- Mirror production folders and namespace suffixes under the test project. For example, `src/Disconance.Models/Channels/Channel.cs` maps to `tests/Disconance.Models.Tests/Channels/TestChannel.cs` with namespace `Disconance.Models.Tests.Channels`.
- Name test files and classes `Test[ClassName]`, omitting generic type parameters (for example, `TestOptional`). Keep each test class focused on one production type.
- Identify one system under test (SUT) per test; name the instance `sut` where applicable. Test its observable public behavior rather than implementation details.
- Follow Arrange-Act-Assert: prepare inputs and the SUT, perform one operation, then verify the outcome. Separate phases with blank lines; comments are optional. Exception assertions may wrap the Act. Multiple assertions are fine when they describe one outcome.
- Name methods `Member_Scenario_ExpectedBehavior`. Use theories for different inputs exercising the same behavior.
- For new behavior and bug fixes, use red-green-refactor: write a focused test, run it and confirm it fails for the intended reason, implement the smallest correct change, then refactor with tests passing. Do not change correct production code just to manufacture a failing test when reorganizing existing tests.
- Test meaningful logic and edge cases, such as optional presence and snowflake parsing. Avoid tests of automatic getters/setters, compiler-enforced type relationships, or framework behavior; do not add tests merely to cover every POCO.
- Keep tests deterministic, independent, and free of network or external services. Restore any ambient state changed by a test, such as culture.

## Organization and validation

- Use C# extension blocks for extension members, grouping members by receiver type. Do not introduce `this`-parameter extension methods.
- Match namespaces to Discord resource organization and folders to namespaces; generally keep each resource type in its own file.
- Use `System.Threading.Lock` for fields used exclusively with `lock` statements.
- Separate multi-line statements in method bodies from adjacent statements with blank lines, including wrapped assignments and calls. Determine whether a statement is multi-line from the entire statement, including its body, not just its header: an `if`, loop, `switch`, `try`, `using`, or `lock` with a body on additional lines is a multi-line statement even when its header fits on one line. Keep leading comments attached to their statement. Do not add blank lines immediately inside braces or separate connected `if`/`else` and `try`/`catch`/`finally` clauses solely for this rule. Check this spacing in all added or edited code before finishing.
- Document public models and fields with XML documentation, including Discord field names and anchored source references. Missing XML documentation and other build warnings are treated as errors.
- Use multi-line XML documentation for text-bearing elements such as `summary`, `remarks`, `param`, `typeparam`, `returns`, and `exception`: put opening and closing tags on separate lines and indent the text four spaces after `/// `. Keep self-closing elements such as `inheritdoc` and `seealso` compact.
- Build and test code changes with:

  ```sh
  dotnet build Disconance.slnx --configuration Release
  dotnet test Disconance.slnx --configuration Release
  ```

## NuGet packaging

- Package metadata lives in each library's project file. Keep prerelease versions until a stable release is intended; override the version for a release with `-p:Version=<version>`.
- After building and testing, run `dotnet pack Disconance.slnx --configuration Release --no-build`. Packages and `.snupkg` symbols are written to `artifacts/packages/`; the test project is not packable.
- The package includes the repository's MIT license and XML API documentation. Keep its description consistent with the library's scope.
- Verify package metadata and contents before publishing; never commit feed credentials or API keys.
