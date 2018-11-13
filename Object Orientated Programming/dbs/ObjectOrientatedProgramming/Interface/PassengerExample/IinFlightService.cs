using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.PassengerExample
{
    public interface IinFlightService
    {
        //Interface by default are public. It should be public becuase we going to reuse
        //Interface are like behaviour is your program (In it's most basic more)
        //Your Interface can be the same
        //Interface are alw ays used starting with capital "I" e.g IinFlightService

        bool IsUpgradeSeat();

        string PurchaseFood(bool food);

        bool IsPurchaseDutyFree(string item);

        string Greeting(string name);
    }
}
