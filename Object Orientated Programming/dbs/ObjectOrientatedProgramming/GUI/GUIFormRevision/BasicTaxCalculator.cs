using System;

namespace dbs.ObjectOrientatedProgramming.GUI.GUIFormRevision
{
    class BasicTaxCalculator
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Single { get; set; } //If there true there single it false there Married
        public double Salary { get; set; }

        public BasicTaxCalculator()
        {

        }

        public BasicTaxCalculator(string firstName, string lastName, bool status, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Single = status;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\nStatus: {Single}\nSalary: {Salary}";
        }

        public double CalculateIncomeTax()
        {
            double taxPayable = 0;
            double balance; 

            if (Single)
            {
                if (Salary <= 34550)
                {
                    taxPayable = (Salary * .2);
                }
                else if (Salary > 34550)
                {
                    taxPayable = (34550 * .2) + ((Salary = 34550) * .4);
                }
            }

            else
            {
                if (Salary <= 69100)
                {
                    taxPayable = Salary * .2;
                }

                else
                {
                    taxPayable = (69100 * .2) + ((Salary = 69100) * .4);
                }
            }

            return taxPayable;
        }

    }
}
