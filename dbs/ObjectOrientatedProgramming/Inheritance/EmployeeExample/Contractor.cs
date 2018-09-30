using System;

namespace dbs.ObjectOrientatedProgramming.Inheritance.EmployeeExample
{
    class Contractor : Employee
    {
        public int DaysWorked { get; set; }
        public double DailyRate { get; set; }
        
        public Contractor(int iD, string name, string gender, int phone, StatusEnum status, ManagerEnum manager, int daysWorked, double dailyRate)
            : base(iD, name, gender, phone, status, manager)
        {
            DaysWorked = daysWorked;
            DailyRate = dailyRate;
        }

        public double GetIncome()
        {
            return DaysWorked * DailyRate;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nDays Worked: {DaysWorked}" + $"\nDaily Rate: ${DailyRate}";
        }
    }

}