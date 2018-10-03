﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Inheritance.EmployeeContractorUserInput
{
    class Contractor:Employee
    {
        public double DailyRate { get; set; }
        public double DaysWorked { get; set; }

        public Contractor()
        { }
        public Contractor(int id, string name, string gender, int phone, int age, StatusEnum status, ManagerEnum manager, double rate, double days)
            :base(id,name,gender,phone,age,status,manager)
        {
            DailyRate = rate;
            DaysWorked = days;
        }

        public double GetIncome()
        {
            return DailyRate * DaysWorked;
        }

        public override string ToString()
        {
            return base.ToString() + "This is the contractor"; 
        }
    }
}
