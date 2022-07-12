using DevInCars.Project.Database;
using DevInCars.Project.Domain.Base;


namespace DevInCars.Project.Domain;

public class VehicleManufactor

{
    public VehicleFactoryBase Vehicle { get; }

    public VehicleManufactor(VehicleFactoryBase vehicle)
    {
        Vehicle = vehicle;
    }
}