using System;

class Alcohol : Drink
{
    public double AlcholContent { get; set; }

    public Alcohol()
    {

    }

    public override string ToString()
    {
        return "This is the alcohol Class";
    }

    public override double GetTax()
    {
        return Price + (Price * .12);
    }
}