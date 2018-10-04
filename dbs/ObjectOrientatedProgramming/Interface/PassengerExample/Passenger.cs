using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.PassengerExample
{
    //If you are inherting from an Interface e.g IinFlightService you must implemnet every aspect in the Interface e.g IinFlightService 
    //Here 
    class Passenger : Person, IinFlightService
    {
        public int PassengerID { get; set; }
        public string SeatNumber { get; set; }

        public PassengerTypeEnum PassengerType { get; set; }

        public string Greeting(string name) //We are taking in their 
        {
            return $"Welcome on {name}";
        }

        public bool IsPurchaseDutyFree(string item)
        {
            return true;
        }

        public string PurchaseFood(bool food)
        {
            if (food)
            {
                return $"Thank you for buying food";
            }

            else
            {
                return "Do you want to Buy anything?";
            }
        }

        public bool IsUpgradeSeat()
        {
            bool success = false;

            switch (PassengerType)
            {
                case PassengerTypeEnum.Economy:
                    PassengerType = PassengerTypeEnum.BusinessClass;
                    success = true;
                    break;

                case PassengerTypeEnum.BusinessClass:
                    PassengerType = PassengerTypeEnum.FirstClass;
                    success = true;
                    break;
            }
            return success;
        }

    }
}
