using System;

namespace dbs.Inheritance.PersonExample
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }

        public Person()
        {

        }

        public Person(string firsName, string lastName, int phone)
        {
            FirstName = firsName;
            LastName = lastName;
            Phone = phone;
        }

        //Override the ToString() Method
        //Override meaning we replace existing code
        //We don't change the ToString()
        //Override replace whereas Overload is add more than one para

        public override string ToString()
        {
            return $"Their name is {FirstName} {LastName}" + $" and Their Phone number is {Phone}";

        }

        //Add to Main
        //Person person1 = new Person("Peter", "Coker", 0123);
        //Person person2 = new Person("John", "Coker", 0123);

        ////Console.WriteLine("Person First Name: {0}", person1.FirstName);
        ////Console.WriteLine("Person Last Name: {0}", person1.LastName);
        ////Console.WriteLine("Person Phone: {0}", person1.Phone);
        ////Console.WriteLine(person1.ToString());
        ////Console.WriteLine(person2.ToString());
    }
}

