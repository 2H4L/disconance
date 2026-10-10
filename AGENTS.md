# Project notes

Disconance is a .NET framework for Discord bots. The current library, `Disconance.Models`, targets .NET 10 and has no NuGet dependencies.

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

- Keep `Disconance.Models` transport-independent. Serialization belongs in a future layer responsible for Discord field names, optional omission, snowflake and permission string encodings, null markers, and polymorphic dispatch. Default JSON serialization is unsupported.
- Include shared data structures such as interaction responses, poll definitions, voice states, and activities.
- Keep network clients, dependency injection, serialization implementations, endpoint request classes, pagination envelopes, access-token exchanges, rate-limit objects, Gateway event envelopes, opcodes, connection handling, dispatch logic, and voice connection protocol messages outside this library.
- SDK-specific, RPC-specific, and undocumented objects are outside this library's scope.

## Organization and validation

- Match namespaces to Discord resource organization and folders to namespaces; generally keep each resource type in its own file.
- Document public models and fields with XML documentation, including Discord field names and anchored source references. Missing XML documentation and other build warnings are treated as errors.
- Build and test code changes with:

  ```sh
  dotnet build Disconance.slnx --configuration Release
  dotnet test Disconance.slnx --configuration Release
  ```
