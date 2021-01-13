using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowHotelBooking
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario(Order = 0)]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            
            //Get all rooms from based on customer's wish
            //Room 1 and 2 are occupied but 3 and 4 free
        }

        [BeforeTestRun]
        public static void BeforeStart()
        {
            //Offer a higher quality room

        }
    }
}
