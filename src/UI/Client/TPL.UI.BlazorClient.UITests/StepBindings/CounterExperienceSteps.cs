namespace TPL.UI.BlazorClient.UITests.Features;

[Binding]
public class CounterExperienceSteps : Steps
{
    private readonly CounterPage _counterPage;

    public CounterExperienceSteps(CounterPage counterPage)
    {
        _counterPage = counterPage;
    }

    [Given(@"I navigate to the counter page")]
    public void GivenINavigateToTheCounterPage()
    {
        _counterPage.NavigateTo();
    }

    [StepDefinition(@"I am on the counter page")]
    public void GivenIAmOnTheCounterPage()
    {
        _counterPage.IsOnPage().Should().BeTrue();
    }
    
    [StepDefinition(@"the counter value is (.*)")]
    public async Task ThenTheCounterValueIs(int counterValue)
    {
        (await _counterPage.GetIncrementValueAsync()).Should().Be(counterValue);
    }

    [When(@"I click the increment button")]
    public void WhenIClickTheIncrementButton()
    {
        _counterPage.IncrementValue();
    }
}