using DevInCars.Project.Domain;
using DevInCars.Project.Domain.Base;

namespace DevInCars.Project.Manager.Processors.Interfaces;

public interface IVehicleProcessor
{
    VehicleManufactorInfo CreateCar(VehicleFactoryBase constructor);
}