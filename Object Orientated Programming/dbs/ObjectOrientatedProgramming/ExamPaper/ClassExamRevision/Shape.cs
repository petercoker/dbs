using System;

namespace dbs.ObjectOrientatedProgramming.ExamPaper.ClassExamRevision
{
    abstract class Shape
    {
        public int NumberOfSides { get; set; }
        public string Colour { get; set; }

        public Shape()
        {

        }

        public Shape(int numberOfSides, string colour)
        {
            NumberOfSides = numberOfSides;
            Colour = colour;
        }

        abstract public double CalculateArea();
    }

}
