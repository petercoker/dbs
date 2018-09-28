using System;

namespace dbs.Inheritance.EmployeeExample
{
    class Contractor : Employee
    {
        public int DaysWorked { get; set; }
        public double DailyRate { get; set; }

        public Contractor()
        {

        }

        public Contractor(int iD, string name, string gender, int phone, StatusEnum status, ManagerEnum manager, int daysWorked, double dailyRate)
            : base(iD, name, gender, phone, status, manager)
        {
            DaysWorked = daysWorked;
            DailyRate = dailyRate;
        }

        public double GetIncome(double income)
        {
            return DaysWorked * DailyRate;
        }


    }

}