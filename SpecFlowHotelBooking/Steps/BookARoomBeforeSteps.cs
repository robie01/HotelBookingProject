using System;
using TechTalk.SpecFlow;

namespace SpecFlowHotelBooking.Steps
{
    [Binding]
    public class BookARoomBeforeSteps
    {
        static DateTime occupiedStartDate = DateTime.Today.AddDays(6);
        static DateTime occupiedEndDate = DateTime.Today.AddDays(12);
        DateTime customerStartDate = DateTime.Today;
        DateTime customerEndDate = DateTime.Today;

        [Given(@"the start date which is tomorrow plus(.*)")]
        public void GivenTheStartDateWhichIsTomorrowPlus(int startDate)
        {
            customerStartDate = customerStartDate.AddDays(startDate);
        }

        [Given(@"the end date which is tomorrow plus(.*)")]
        public void GivenTheEndDateWhichIsTomorrowPlus(int endDate)
        {
            customerEndDate = customerEndDate.AddDays(endDate);
        }

        [When(@"the dates are checked to be correct")]
        public void WhenTheDatesAreCheckWithinTheOccupiedRange()
        {
            if (customerEndDate <= customerStartDate ||
                customerStartDate <= DateTime.Today ||
                customerEndDate <= DateTime.Today)
            {
                Console.WriteLine("Exception");
                throw new Exception("Make sure the dates are correct and related to today.");
            }
        }

        [Then(@"the (.*) should be returned")]
        public bool ThenTheShouldBeReturned()
        {
            if (customerStartDate > occupiedStartDate ||
                (customerEndDate < occupiedEndDate && customerEndDate > occupiedStartDate) ||
                (customerEndDate > customerEndDate && customerStartDate < customerStartDate))
            {
                Console.WriteLine("True");
                return false;
            }
            else
            {
                Console.WriteLine("True");
                return true;
            }
        }
    }
}

