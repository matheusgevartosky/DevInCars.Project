using DevInCars.Project.Domain.Base;
using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Domain;

public class CarFactory : VehicleFactoryBase
{
    public CarFactory(Guid chassisNumber, DateOnly manufacturingDate, string name, string plateNumber, double value,
        string color, double potency, FuelType fuelType, VehicleStatus status, int id, VehicleType type,
        string? buyerId, int doorsNumber = 0) :
        base(chassisNumber, manufacturingDate, name, plateNumber, value, color, potency, fuelType,
            status, id,type, buyerId, doorsNumber)
    {
    }
}