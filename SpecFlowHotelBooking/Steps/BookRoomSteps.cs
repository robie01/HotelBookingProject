using System;
using TechTalk.SpecFlow;

namespace SpecFlowHotelBooking.Steps
{
    [Binding]
    public sealed class BookRoomSteps   
    {

        private readonly ScenarioContext _scenarioContext;

        public BookRoomSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"the start date which is tomorrow plus (.*)")]
        public void GivenTheStartDateWhichIsTomorrowPlus(int p0)
        {
            _scenarioContext.Pending();
        }
        
        [Given(@"the end date which is tomorrow plus (.*)")]
        public void GivenTheEndDateWhichIsTomorrowPlus(int p0)
        {
            _scenarioContext.Pending();
        }
        
        [When(@"the dates are check with the occupied range")]
        public void WhenTheDatesAreCheckWithTheOccupiedRange()
        {
            _scenarioContext.Pending();
        }
        
        [Then(@"the True should be returned")]
        public void ThenTheTrueShouldBeReturned()
        {
            _scenarioContext.Pending();
        }
    }
}
