using DevInCars.Project.Domain.Base;
using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Domain;

public class VehicleManufactorInfo

{
    public VehicleManufactorInfo(VehicleFactoryBase vehicle )
    {
        Vehicle = vehicle;
        
    }

    public VehicleFactoryBase Vehicle { get; }
    
}