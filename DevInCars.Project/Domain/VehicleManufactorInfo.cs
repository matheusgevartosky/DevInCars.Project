using DevInCars.Project.Database;
using DevInCars.Project.Domain.Base;


namespace DevInCars.Project.Domain;

public class VehicleManufactorInfo

{
    public VehicleFactoryBase Vehicle { get; }

    public VehicleManufactorInfo(VehicleFactoryBase vehicle)
    {
        Vehicle = vehicle;
    }
}