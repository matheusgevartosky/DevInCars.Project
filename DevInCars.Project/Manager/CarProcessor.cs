using DevInCars.Project.Domain;
using DevInCars.Project.Domain.Base;
using DevInCars.Project.Manager.Processors.Base;
using DevInCars.Project.Manager.Processors.Interfaces;


namespace DevInCars.Project.Manager;

public class CarProcessor : ProcessorBase<CarFactory>, IVehicleProcessor
{
    public   VehicleManufactorInfo CreateCarAuth(VehicleFactoryBase constructor)
    {
        var createCar = ValidateVehicleType(constructor);

        
        return Car(createCar);
    }
    
    private static VehicleManufactorInfo Car (CarFactory carFactory)
    {
        return new VehicleManufactorInfo(carFactory);

    }
}

