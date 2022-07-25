using DevInCars.Project.Domain;
using DevInCars.Project.Domain.Base;
using DevInCars.Project.Manager.Processors.Base;
using DevInCars.Project.Manager.Processors.Interfaces;

namespace DevInCars.Project.Manager;

public class TruckProcessor : ProcessorBase<TruckFactory>, IVehicleProcessor
{
    public VehicleFactoryBase CreateVehicle(VehicleFactoryBase vehicle)
    {
        var createdTruck = ValidateVehicleType(vehicle);

        return createdTruck;
    }
}
    
