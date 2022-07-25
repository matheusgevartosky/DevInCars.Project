using DevInCars.Project.Domain.Base;
using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Domain;

public class TruckFactory : VehicleFactoryBase
{
    public float cart { get; }
    public TruckFactory(Guid chassisNumber, DateOnly manufacturingDate, string name, string plateNumber, double value,
        double potency, FuelType fuelType, VehicleStatus status, int id, VehicleType type,float cart, string? buyerId,
        int doorsNumber = 0,
        string color = "Purple") : base(chassisNumber, manufacturingDate, name, plateNumber, value, color, potency, 
        fuelType, status, id, type, buyerId, doorsNumber)
    {
    }
    
    public override string ToString()
    {
        return $"Modelo: {Name}\n Placa: {PlateNumber}\n Valor: {Value}  ";
    }
}