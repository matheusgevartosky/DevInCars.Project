using DevInCars.Project.Domain;
using DevInCars.Project.Domain.Base;
using DevInCars.Project.Manager.Processors.Base;
using DevInCars.Project.Manager.Processors.Interfaces;

namespace DevInCars.Project.Manager;

public class CarProcessor : ProcessorBase<CarFactory>, IVehicleProcessor
{
    public static VehicleManufactorInfo CreateCar1(VehicleFactoryBase constructor)
    {
        var carro = constructor;

        return new VehicleManufactorInfo(constructor);
    }


    public VehicleManufactorInfo CreateCar(VehicleFactoryBase constructor)
    {
        throw new NotImplementedException();
    }
}

