using System;

namespace dbs.ObjectOrientatedProgramming.ExamPaper.ClassExamRevision
{
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; } 

        public Rectangle()
        {

        }

        public Rectangle(double height, double width, int numberOfSides, string colour) : base(numberOfSides, colour)
        {
            Height = height;
            Width = width;
        }

        public override double CalculateArea()
        {
            double rectangle;

            rectangle = Width * Height;

            //Or  return Height * Width;
            return rectangle;
        }

        public override string ToString()
        {
            return $"The rectangle has a height of {Height} and a width of {Width}\n";
        }
    }
}
