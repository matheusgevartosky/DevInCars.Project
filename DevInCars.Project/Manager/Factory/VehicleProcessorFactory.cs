using DevInCars.Project.Domain.Enum;
using DevInCars.Project.Manager.Processors.Interfaces;

namespace DevInCars.Project.Manager.Factory;

public class VehicleProcessorFactory
{
    public static IVehicleProcessor CreateVehicleProcessor(VehicleType vehicleType)
    {
        switch (vehicleType)
        {
            case VehicleType.Carro: return new CarProcessor();

            default: throw new ArgumentException("nada");
        }
    }
}