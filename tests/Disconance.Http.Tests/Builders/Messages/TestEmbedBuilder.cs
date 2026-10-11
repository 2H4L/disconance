using Disconance.Http.Builders.Messages;
using Disconance.Models.Messages;

namespace Disconance.Http.Tests.Builders.Messages;

public class TestEmbedBuilder
{
    [Fact]
    public void Build_NestedContent_ProducesIndependentSnapshot()
    {
        var field = new EmbedField { Name = "status", Value = "ready" };
        var sut = new EmbedBuilder().WithTitle("Status").AddField(field);

        var result = sut.Build();
        field.Value = "changed";
        sut.WithTitle("Changed");

        Assert.Equal("Status", result.Title.Value);
        Assert.Equal("ready", result.Fields.Value[0].Value);
    }

    [Fact]
    public void Build_OmittedField_LeavesOptionalAbsent()
    {
        var sut = new EmbedBuilder().WithTitle("Status").OmitTitle();

        var result = sut.Build();

        Assert.False(result.Title.HasValue);
    }

    [Fact]
    public void Build_MissingNestedRequiredValue_Throws()
    {
        var sut = new EmbedFieldBuilder().WithName("status");

        Assert.Throws<InvalidOperationException>(() => sut.Build());
    }
}
