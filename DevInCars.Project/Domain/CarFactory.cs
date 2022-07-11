using DevInCars.Project.Domain.Base;
using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Domain;

public class CarFactory : VehicleFactoryBase
{
    

    public CarFactory(Guid chassisNumber, DateOnly manufacturingDate, string name, string plateNumber, double value, 
        long buyerId, string color, float potency, FuelType fuelType, int? doorsNumber) :
        base(chassisNumber, manufacturingDate, name, plateNumber, value, buyerId, color, potency, fuelType, doorsNumber)
    {
    }
}