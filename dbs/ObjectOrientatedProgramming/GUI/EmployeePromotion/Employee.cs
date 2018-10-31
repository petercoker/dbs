using System;

namespace dbs.ObjectOrientatedProgramming.GUI.EmployeePromotion
{
    class Employee
    {
        public string Name { get; set; }
        public int YearsWorked { get; set; }
        public int PositionPoint { get; set; }

        public Employee()
        {

        }

        public Employee(string name, int years, int position)
        {
            Name = name;
            YearsWorked = years;
            PositionPoint = position;
        }

        public override string ToString()
        {
            return $"{Name} is on point {PositionPoint} in the scale and worked here for {YearsWorked} years"; 
        }

        public bool Promotion()
        {
            bool promo = false;

            if (YearsWorked > 5 && PositionPoint > 3)
            {
                promo = true;
            }

            return promo;
        }
    }
}
