using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Domain.Base;

public abstract class VehicleFactoryBase
{
    protected VehicleFactoryBase(Guid chassisNumber, DateOnly manufacturingDate, string name, string plateNumber,
        double value, long buyerId, string color, double potency, FuelType fuelType, int? doorsNumber, VehicleStatus status)
    {
        ChassisNumber = chassisNumber;
        ManufacturingDate = manufacturingDate;
        Name = name;
        PlateNumber = plateNumber;
        Value = value;
        BuyerId = buyerId;
        Color = color;
        Potency = potency;
        FuelType = fuelType;
        DoorsNumber = doorsNumber;
        Status = status;
    }

    public Guid ChassisNumber { get; }
    public DateOnly ManufacturingDate { get; }
    public string Name { get; }
    public string PlateNumber { get; }
    public double Value { get; }
    public long BuyerId { get; }
    public string Color { get; }

    public double Potency { get; }
    public FuelType FuelType { get; }
    public int? DoorsNumber { get; }
    
    public VehicleStatus Status { get; } 
}