using System;

namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Teacher : Employee, IComparable
    {
        public TaughtEnum Taught { get; set; }

        public Teacher()
        {

        }

        public Teacher(string name, int phone, string email, int employeeID, bool isCurrentEmployee, double salary, TaughtEnum taught)
            : base(name, phone, email, employeeID, isCurrentEmployee, salary)
        {
            Taught = taught;
        }

        public override string ToString()
        {
            return $"\nEmployee ID: {EmployeeID}\nTeacher is current staff: {IsCurrentEmployee}\nTeacher Name: {Name}\nPhone: {Phone}\nEmail: {Email}\nTaught: {Taught}\nSalary: ${Salary}";
        }

        public int CompareTo(object other)
        {
            int sort = 0;
            Teacher teacher = other as Teacher;

            if (other != null)
            {
                sort = this.EmployeeID.CompareTo(teacher.EmployeeID);
            }

            return sort;
        }
    }
}
