using DevInCars.Project.Domain.Base;
using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Domain;

public class CarFactory : VehicleFactoryBase
{
    

    public CarFactory(Guid chassisNumber, DateOnly manufacturingDate, string name, string plateNumber, double value, 
        long buyerId, string color, double potency, FuelType fuelType, int? doorsNumber, VehicleStatus status) :
        base(chassisNumber, manufacturingDate, name, plateNumber, value, buyerId, color, potency, fuelType, doorsNumber, status)
    {
    }
}