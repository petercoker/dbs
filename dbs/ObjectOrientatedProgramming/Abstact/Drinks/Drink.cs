using System;

class SoftDrink : Drink
{
    public string Colour { get; set; }

    public SoftDrink()
    {

    }

    public SoftDrink(string name, double price, string colour)
        : base(name, price)
    {
        Colour = colour;
    }

    public override string ToString()
    {
        return "This is the soft drink class";
    }

    public override double GetTax()
    {
        return Price * .12;
        //throw new NotImplementedException(); //This allow you to throw something without implemtentin somthing
    }
}