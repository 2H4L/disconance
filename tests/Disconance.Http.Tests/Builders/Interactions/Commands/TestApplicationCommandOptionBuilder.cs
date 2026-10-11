using Disconance.Http.Builders.Interactions.Commands;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Tests.Builders.Interactions.Commands;

public class TestApplicationCommandOptionBuilder
{
    [Fact]
    public void Build_NestedIntegerChoice_PreservesScalarVariant()
    {
        var sut = new ApplicationCommandOptionBuilder().WithType(ApplicationCommandOptionType.Integer)
            .WithName("count").WithDescription("A count")
            .AddChoice(choice => choice.WithName("maximum").WithValue(long.MaxValue));

        var result = sut.Build();

        Assert.Equal(long.MaxValue, Assert.IsType<IntegerCommandValue>(result.Choices.Value[0].Value).Value);
    }
}