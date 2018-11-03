using System;

namespace dbs.ObjectOrientatedProgramming.ExamPaper.ClassExamRevision
{
    class Square : Shape
    {
        public double SideLength { get; set; }

        public Square()
        {

        }

        public Square(double sideLenght, int numberOfSides, string colour) : base(numberOfSides, colour)
        {
            SideLength = sideLenght;
        }
        
        public override double CalculateArea()
        {
            double square;

            square = Math.Pow(SideLength, 2);
           
            return square;
        }
        
    }
}
