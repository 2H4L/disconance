using Disconance.Http.Builders.Interactions;
using Disconance.Models.Components;
using Disconance.Models.Interactions;

namespace Disconance.Http.Tests.Builders.Interactions;

public class TestInteractionResponseBuilder
{
    [Fact]
    public void Build_NestedModal_ComposesDisplayConfiguration()
    {
        var sut = new InteractionResponseBuilder().WithModal(modal => modal
            .WithCustomId("delivery").WithTitle("Delivery details")
            .AddLabel(label => label.WithLabel("Instructions").WithComponentTextInput(input => input
                .WithCustomId("instructions").WithStyle(TextInputStyle.Paragraph))));

        var result = sut.Build();

        Assert.Equal(InteractionCallbackType.Modal, result.Type);
        var modal = Assert.IsType<InteractionModalData>(result.Data.Value);

        Assert.IsType<TextInput>(
            Assert.IsType<LabelComponent>(modal.Components[0]).Component);
    }

    [Fact]
    public void Build_MismatchedData_RejectsStructuralConflict()
    {
        var sut = new InteractionResponseBuilder().WithType(InteractionCallbackType.Modal)
            .WithData(new InteractionMessageData { Content = "hello" });

        Assert.Throws<InvalidOperationException>(() => sut.Build());
    }
}