using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Domain;

public class ManufactorInfo
{
    
    public Guid ChassisNumber { get; }
    public DateOnly ManufacturingDate { get; }
    public string Name { get; }
    public string PlateNumber { get; }
    public double Value { get; }
    public long BuyerId { get; }
    public string Color { get; }

    public ManufactorInfo(Guid chassisNumber, DateOnly manufacturingDate, string name, string plateNumber, double value,
        long buyerId, string color)
    {
        ChassisNumber = chassisNumber;
        ManufacturingDate = manufacturingDate;
        Name = name;
        PlateNumber = plateNumber;
        Value = value;
        BuyerId = buyerId;
        Color = color;
    }
}