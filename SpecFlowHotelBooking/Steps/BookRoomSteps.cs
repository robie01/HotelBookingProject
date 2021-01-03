using HotelBookingStartupProject.Interfaces;
using HotelBookingStartupProject.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Globalization;
using TechTalk.SpecFlow;

namespace SpecFlowHotelBooking.Steps
{
    [Binding]
    public class BookRoomSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public readonly Booking _booking = new Booking();

        DateTime startOccupiedRange = DateTime.Today.AddDays(10);
        DateTime endOccupiedRange = DateTime.Today.AddDays(20);


        public BookRoomSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

       
        [Given(@"the start date which is tomorrow plus'(.*)'")]
        public void GivenTheStartDateWhichIsTomorrowPlus(string startDate)
        {
            DateTime parsedDate = DateTime.ParseExact(startDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            _booking.StartDate = parsedDate;
           
        }
        
        [Given(@"the end date which is tomorrow plus'(.*)'")]
        public void GivenTheEndDateWhichIsTomorrowPlus(string endDate)
        {
            DateTime parsedDate = DateTime.ParseExact(endDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            _booking.EndDate = parsedDate;
        }

        [When(@"the dates are check with the occupied range")]
        public void WhenTheDatesAreCheckWithTheOccupiedRange()
        {

            if ((_booking.StartDate <= startOccupiedRange && _booking.EndDate <= startOccupiedRange || _booking.StartDate > endOccupiedRange && _booking.EndDate > endOccupiedRange))
            {
                 _booking.IsActive = true;
            }
           
            


        }

         [Then(@"the '(.*)' should be returned")]
        public void ThenTheShouldBeReturned(string p0)
        {
           
            if(_booking.IsActive == false)
            {
                Console.WriteLine(p0, "Cant book at this period");
            }
            else
            {
                Console.WriteLine(p0, "Its available");
              
            }

            //true = true
                //true = false
                //false = false
        }
    }
}
