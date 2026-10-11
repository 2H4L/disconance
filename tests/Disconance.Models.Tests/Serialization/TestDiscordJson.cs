using System.Text.Json;
using Disconance.Models.Applications;
using Disconance.Models.Components;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;
using Disconance.Models.Messages;
using Disconance.Models.Permissions;
using Disconance.Models.Serialization;

namespace Disconance.Models.Tests.Serialization;

public class TestDiscordJson
{
    [Theory]
    [InlineData("2147483648")]
    [InlineData("\"Button\"")]
    public void CreateOptions_InvalidEnum_ThrowsJsonException(string json)
    {
        var sut = DiscordJson.CreateOptions();

        Assert.Throws<JsonException>(() => JsonSerializer.Deserialize<ComponentType>(json, sut));
    }

    [Fact]
    public void CreateOptions_EnumDictionaryKeys_UsesNumericWireNames()
    {
        var sut = DiscordJson.CreateOptions();

        var owners = new Dictionary<ApplicationIntegrationType, Snowflake>
            { [ApplicationIntegrationType.GuildInstall] = 42UL };

        var json = JsonSerializer.Serialize(owners, sut);

        Assert.Equal("{\"0\":\"42\"}", json);
    }

    [Theory]
    [InlineData(2, "{\"id\":\"3\",\"name\":\"test\",\"type\":1}", typeof(ApplicationCommandData))]
    [InlineData(3, "{\"custom_id\":\"button\",\"component_type\":2}", typeof(MessageComponentData))]
    [InlineData(5,
        "{\"custom_id\":\"form\",\"components\":[{\"type\":18,\"id\":1,\"component\":{\"type\":4,\"id\":2,\"custom_id\":\"text\",\"value\":\"hello\"}}]}",
        typeof(ModalSubmitData))]
    public void CreateOptions_IncomingInteraction_SelectsContextualData(int type, string data, Type expected)
    {
        var sut = DiscordJson.CreateOptions();

        var json = $$"""
                     {"id":"1","application_id":"2","type":{{type}},"data":{{data}},"token":"test","version":1,
                      "app_permissions":"0","entitlements":[],"authorizing_integration_owners":{"0":"42"},"attachment_size_limit":100}
                     """;

        var result = JsonSerializer.Deserialize<Interaction>(json, sut)!;

        Assert.IsType(expected, result.Data.Value);
        Assert.Contains("\"data\":", JsonSerializer.Serialize(result, sut));
    }

    [Fact]
    public void CreateOptions_NumberCommandOption_UsesEnclosingType()
    {
        var sut = DiscordJson.CreateOptions();

        var result = JsonSerializer.Deserialize<ApplicationCommandInteractionDataOption>(
            "{\"name\":\"size\",\"type\":10,\"value\":1}", sut)!;

        Assert.IsType<NumberCommandValue>(result.Value.Value);
    }

    [Fact]
    public void CreateOptions_ConcreteScalar_WritesWireValue()
    {
        var sut = DiscordJson.CreateOptions();

        var result = JsonSerializer.Serialize(new IntegerCommandValue(42), sut);

        Assert.Equal("42", result);
    }

    [Fact]
    public void CreateOptions_UnknownComponent_ThrowsJsonException()
    {
        var sut = DiscordJson.CreateOptions();

        Assert.Throws<JsonException>(() => JsonSerializer.Deserialize<Component>("{\"type\":999}", sut));
    }

    [Fact]
    public void CreateOptions_PermissionAndNullMarker_RoundTrips()
    {
        var sut = DiscordJson.CreateOptions();
        var permissions = (PermissionFlags)ulong.MaxValue;

        var result = JsonSerializer.Serialize(permissions, sut);
        var tags = JsonSerializer.Deserialize<RoleTags>("{\"premium_subscriber\":null}", sut)!;

        Assert.Equal("\"18446744073709551615\"", result);
        Assert.True(tags.PremiumSubscriber.HasValue);
        Assert.Equal("{\"premium_subscriber\":null}", JsonSerializer.Serialize(tags, sut));
    }

    [Fact]
    public void CreateOptions_OptionalValues_PreservesPresence()
    {
        var sut = DiscordJson.CreateOptions();
        var value = new Embed { Title = "hello", Color = 0 };

        var json = JsonSerializer.Serialize(value, sut);

        Assert.Equal("{\"title\":\"hello\",\"color\":0}", json);
    }

    [Fact]
    public void CreateOptions_ExplicitNull_PreservesPresence()
    {
        var sut = DiscordJson.CreateOptions();

        var value = JsonSerializer.Deserialize<Thumbnail>(
            "{\"type\":11,\"media\":{\"url\":\"attachment://test.png\"},\"description\":null}", sut)!;

        Assert.True(value.Description.HasValue);
        Assert.Null(value.Description.Value);
        Assert.Contains("\"description\":null", JsonSerializer.Serialize(value, sut));
    }

    [Fact]
    public void CreateOptions_NestedCallback_RoundTripsConcreteComponents()
    {
        var sut = DiscordJson.CreateOptions();

        const string json =
            "{\"type\":4,\"data\":{\"tts\":false,\"components\":[{\"type\":1,\"components\":[{\"type\":2,\"style\":1,\"custom_id\":\"ok\"}]}]}}";

        var value = JsonSerializer.Deserialize<InteractionResponse>(json, sut)!;

        var data = Assert.IsType<InteractionMessageData>(value.Data.Value);
        Assert.False(data.Tts.Value);
        Assert.IsType<Button>(Assert.IsType<ActionRow>(data.Components.Value[0]).Components[0]);
        Assert.Contains("\"custom_id\":\"ok\"", JsonSerializer.Serialize(value, sut));
    }

    [Fact]
    public void CreateOptions_SnowflakeDictionary_PreservesUnsignedRange()
    {
        var sut = DiscordJson.CreateOptions();
        var value = new Dictionary<Snowflake, Snowflake> { [ulong.MaxValue] = ulong.MaxValue };

        var json = JsonSerializer.Serialize(value, sut);

        Assert.Equal("{\"18446744073709551615\":\"18446744073709551615\"}", json);
        Assert.Equal(value, JsonSerializer.Deserialize<Dictionary<Snowflake, Snowflake>>(json, sut));
    }
}