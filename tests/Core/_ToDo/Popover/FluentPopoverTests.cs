using Bunit;
using Xunit;

namespace Microsoft.FluentUI.AspNetCore.Components.Tests.Popover;
public class FluentPopoverTests : TestBase
{
    [Fact]
    public void FluentPopover_Default()
    {
        //Arrange
        string header = "<b>render me</b>";
        string body = "<b>render me</b>";
        string footer = "<b>render me</b>";
        string anchorId = default!;
        HorizontalPosition? horizontalPosition = default!;
        bool open = default!;
        Action<System.Boolean> openChanged = _ => { };
        var cut = TestContext.RenderComponent<FluentPopover>(parameters => parameters
            .Add(p => p.AnchorId, anchorId)
            .Add(p => p.HorizontalPosition, horizontalPosition)
            .Add(p => p.Open, open)
            .Add(p => p.OpenChanged, openChanged)
            .Add(p => p.Header, header)
            .Add(p => p.Body, body)
            .Add(p => p.Footer, footer)
        );
        //Act

        //Assert
		cut.Verify();
    }
}






