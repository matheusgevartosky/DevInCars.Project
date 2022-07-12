using DevInCars.Project.Domain;
using DevInCars.Project.Domain.Base;
using DevInCars.Project.Manager.Processors.Base;
using DevInCars.Project.Manager.Processors.Interfaces;


namespace DevInCars.Project.Manager;

public class CarProcessor : ProcessorBase<CarFactory>, IVehicleProcessor
{
    public VehicleFactoryBase CreateVehicle(VehicleFactoryBase constructor)
    {
        var createdCar = ValidateVehicleType(constructor);
        
        return createdCar;
    }
}

