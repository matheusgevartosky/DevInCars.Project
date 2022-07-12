using DevInCars.Project.Domain;
using DevInCars.Project.Domain.Base;

namespace DevInCars.Project.Manager.Processors.Interfaces;

public interface IVehicleProcessor
{
       public VehicleFactoryBase CreateVehicle(VehicleFactoryBase constructor);
}