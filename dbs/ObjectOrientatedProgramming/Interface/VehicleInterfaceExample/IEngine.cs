using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbs.ObjectOrientatedProgramming.Interface.VehicleInterfaceExample
{
    interface IEngine
    {
        FuelType Fuel { get; set; }
        double EngineSize { get; set; }

        bool StartEngine();

        bool TurnOffEngine();

    }
}
