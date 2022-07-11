using DevInCars.Project.Domain.Base;
using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Domain;

public class VehicleManufactorInfo

{
    public VehicleManufactorInfo(VehicleFactoryBase vehicle, VehicleStatus status)
    {
        Vehicle = vehicle;
        Status = status;
    }

    public VehicleFactoryBase Vehicle { get; }
    public VehicleStatus Status { get; }
}