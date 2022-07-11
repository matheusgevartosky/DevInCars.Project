using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Domain.Base;

public abstract class VehicleFactoryBase
{
    protected VehicleFactoryBase(Guid chassisNumber, DateOnly manufacturingDate, string name, string plateNumber,
        double value, long buyerId, string color, float potency, FuelType fuelType, int? doorsNumber)
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
    }

    public Guid ChassisNumber { get; }
    public DateOnly ManufacturingDate { get; }
    public string Name { get; }
    public string PlateNumber { get; }
    public double Value { get; }
    public long BuyerId { get; }
    public string Color { get; }

    public float Potency { get; }
    public FuelType FuelType { get; }
    public int? DoorsNumber { get; }
}