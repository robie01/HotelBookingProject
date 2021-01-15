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
        public void CheckHolidaySeason()
        {
            //Check holiday season
        }

        [BeforeScenario(Order = 1)]
        public void CheckHotelFreeRoom()
        {
        }

        [BeforeScenario(Order = 2)]
        public void ModifyPrice()
        {
        }

    }
}
