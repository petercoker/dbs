using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.PassengerExample
{
    class Person
    {
        public TitleEnum Title { get; set; }

        public string FirstName { get; set; }
        public string Surname { get; set; }

        public Address Address { get; set; } //The Class is being used as a data type, It make the code reuseable



        public Person()
        {

        }

        //Add to Main()
        ////Passenger p1 = new Passenger();
        ////Address add1 = new Address();

        ////add1.HouseNumber = "5";
        ////    add1.Street = "Fake Street";
        ////    add1.City = "Dublin";
        ////    add1.County = "Dublin";

        ////    p1.Title = TitleEnum.Mr;
        ////    p1.FirstName = "John";
        ////    p1.Surname = "Murphy ";
        ////    p1.Address = add1; //The address property is add by "add1"
        ////    p1.PassengerType = PassengerTypeEnum.BusinessClass;

        ////    Console.WriteLine(p1.Greeting(p1.FirstName));
        ////    Console.WriteLine(p1.Address.ToString());

        ////    Console.WriteLine(p1.IsUpgradeSeat());
        ////    Console.WriteLine(p1.PurchaseFood(false));

    }
}
