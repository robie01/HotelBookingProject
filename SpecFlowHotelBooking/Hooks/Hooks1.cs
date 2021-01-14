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
            //Based on Hotel's availability, offers more or less room.
        }

        [BeforeTestRun]
        public static void BeforeStart()
        {
            //Order rooms by quality

        }
    }
}
