using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.ExamPaper.ClassExamRevision
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square(1.5, 6, "Clear");
            Console.WriteLine($"The area is {s1.CalculateArea()}");

            Rectangle r1 = new Rectangle(4.5, 5, 5, "purple");
            Console.WriteLine(r1.ToString() + $"The Area is {r1.CalculateArea()}");
      

        }
    }
}