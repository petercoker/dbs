using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.ExamPaper.InterfaceRevision
{
    class Admin: Person, IClient
    {
        public double Salary { get; set; }
        public PositionEnum Position { get; set; }
        public string Email { get; set; }

        public Admin()
        { }

        public Admin(string name, int phone, double sal, PositionEnum pos, string email)
            :base(name, phone)
        {
            Salary = sal;
            Position = pos;
            Email = email;
        }

        public string DirectClient()
        {
            return "Please go to the Admin offices";
        }

        public string GreetClient()
        {
            return $"Hello {Name} enjoy work today";
        }
    }
}
