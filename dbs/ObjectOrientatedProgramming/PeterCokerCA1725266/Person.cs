namespace dbs.ObjectOrientatedProgramming.PeterCokerCA1725266
{
    class Person
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public Person()
        {
            
        }

        public Person(string name, int phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
