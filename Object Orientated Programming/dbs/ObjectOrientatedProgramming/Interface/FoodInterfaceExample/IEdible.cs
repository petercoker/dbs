using System;

namespace dbs.ObjectOrientatedProgramming.Interface.FoodInterfaceExample
{
    //Interface contains definitions for a group of related 
    //functionalities that a class can implement
    //Using an interface you can include behaviours from multiple sources
    //Naming convention on an interface is IName
    //Interfaces can contain events, methods and properties
    //Interfaces contain NO implementation of methods.
    interface IEdible
    {
        string AnimalType { get; set; }
        string Prepare();
        string Taste();
 

    }
}
