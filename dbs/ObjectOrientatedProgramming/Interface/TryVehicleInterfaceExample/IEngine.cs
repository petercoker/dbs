using System;

namespace dbs.ObjectOrientatedProgramming.Interface.TryVehicleInterfaceExample
{
    public interface IEngine
    {
        FuelTypeEnum FuelType { get; set; }
        double EngineSize { get; set; }

        bool StartEngine();
        bool TurnOffEngine();
    }
}
