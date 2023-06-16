namespace TPL.UI.BlazorClient.UIUnitTests;

public class CounterComponentTests
{
    [Fact]
    public void CounterComponentTest()
    {
        // Given I have a counter component
        using var ctx = new TestContext();
        var component = ctx.RenderComponent<Counter>();

        // And the counter is initialized to 0
        component.Find("#currentCount").TextContent.Should().Be("0");
        
        // When I increment the count
        component.Find("#incrementPlus").Click();

        // The count should be 1
        component.Find("#currentCount").TextContent.Should().Be("1");
        
    }
}