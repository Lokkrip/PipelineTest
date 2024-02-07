using Bunit;
using PipelineTest.Components.Pages;
using System.Diagnostics.Metrics;

namespace BlazorTestProject
{
    public class UnitTest1 : TestContext
    {
        [Fact]
        public void CounterShouldIncrementWhenClicked()
        {
            // Arrange: render the Counter.razor component
            var cut = RenderComponent<Counter>();

            // Act: find and click the <button> element to increment
            // the counter in the <p> element
            cut.Find("button").Click();

            // Assert: first find the <p> element, then verify its content
            cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");
        }
    }
}
