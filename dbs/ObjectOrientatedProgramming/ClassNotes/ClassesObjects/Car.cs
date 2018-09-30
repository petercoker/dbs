using System;

namespace dbs.ObjectOrientatedProgramming.ClassNotes.ClassesObjects
{
    class Car
    {
        //instance variables / Objects of Classes

        //private string colour;
        //private int noOfDoors;
        //private double currentSpped;

        //properites (Old way of doing it)

        //public string Color
        //{
        //    get { return colour; }
        //    set { colour = value; }
        //}

        //public int NoOfDoors
        //{
        //    get { return noOfDoors; }
        //    set { noOfDoors = value; }
        //}

        //public double CurrentSpped
        //{
        //    get { return currentSpeed;}
        //    set { currentSpeed = value; }
        //}

        //Auto-Implemented Properties (Best way)
        //c# does automatically implemented properties no need to define private instance varibales e.g;
        public string Colour { get; set; }
        public int NoOfDoors { get; set; }
        public double CurrentSpeed { get; set; }

        //You must build an object of a class before you can make an application 
        //that performs the tasks decribed by the class.
        //Constractor/Constractors allows us to send messages to an object by making method calls 

        //Default Constructors
        //public Car()
        //{

        //}

        //public Car(string carColour)
        //{
        //    Colour = carColour;
        //}

        //public Car(string carColour, int doors) : this(carColour, doors, 40.00)
        //{

        //}

        //public Car(string colour)
        //{
        //    this.Colour = colour;
        //}
        //You can define one or more than one constuctor in a class

        public Car(string carColour, int doors, double speed)
        {
            Colour = carColour;
            NoOfDoors = doors;
            CurrentSpeed = speed;
        }

        //methods
        public void Accelerate(double newSpeed)
        {
            if (newSpeed > CurrentSpeed)
            {
                CurrentSpeed = newSpeed;
            }
        }

        public void ReduceSpeed(double newSpeed)
        {
            if (newSpeed < CurrentSpeed)
            {
                CurrentSpeed = newSpeed;
            }
        }

        //Add to Main()
        //Car car1 = new Car(); //Default constructor 

        //cart1.Colour = "Blue"; //Calling set
        //car1.NoOfDoors = 4; //Calling Set
        //car1.CurrentSpeed = 35; //Calling set

        //Car car1 = new Car("Blue", 4, 35); //You have to call more than one constructors
        //car1.Accelerate(60);
        //System.Console.WriteLine("Colour: {0}", car1.Colour);
        //System.Console.WriteLine("No of Doors: {0}", car1.NoOfDoors);
        //System.Console.WriteLine("Current Speed: {0}", car1.CurrentSpeed);

        //Console.ReadLine();
    }
}
