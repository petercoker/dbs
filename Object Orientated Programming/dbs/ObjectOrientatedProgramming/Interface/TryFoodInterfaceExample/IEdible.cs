using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.TryFoodInterfaceExample
{
    public interface IEdible
    {
        string AnimalType { get; set; }
        string Prepare();
        string Taste();
    }
}
