namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Employee : Person
    {
        public int EmployeeID { get; set; }
        public bool IsCurrentEmployee { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            
        }

        public Employee(string name, int phone, string email, int employeeID, bool isCurrentEmployee, double salary)
            : base(name, phone, email)
        {
            EmployeeID = employeeID;
            IsCurrentEmployee = isCurrentEmployee;
            Salary = salary;
        }
    }
}
