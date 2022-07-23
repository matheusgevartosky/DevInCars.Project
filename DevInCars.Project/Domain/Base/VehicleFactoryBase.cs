using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Domain.Base;

public abstract class VehicleFactoryBase
{
    public Guid ChassisNumber { get; }
    public DateOnly ManufacturingDate { get; }
    public string Name { get; }
    public string PlateNumber { get; }
    public double Value { get; }
    public long BuyerId { get; }
    public string Color { get; }
    public double Potency { get; }
    public FuelType FuelType { get; }
    public int DoorsNumber { get; }
    public VehicleStatus Status { get; }
    public int Id { get; }

    public VehicleType Type { get; }


    protected VehicleFactoryBase(Guid chassisNumber, DateOnly manufacturingDate, string name, string plateNumber,
        double value, string color, double potency, FuelType fuelType,
        VehicleStatus status, int id, VehicleType type, long buyerId = 0, int doorsNumber = 0)
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
        Id = id;
        Type = type;
    }
}