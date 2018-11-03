using System;

namespace dbs.ObjectOrientatedProgramming.ExamPaper.InterfaceRevision
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin("Claire", 123456, 20000, PositionEnum.Admin, "c.c@dbs.ie");
            Console.WriteLine(admin.GreetClient());
            Console.WriteLine(admin.DirectClient());
            
            Student stu = new Student("Brian", 25874, 2016, "brian@dbs.ie");
            Console.WriteLine(stu.ToString());
            Console.WriteLine(stu.GreetClient() + " " + stu.DirectClient());
            
        }
    }
}
