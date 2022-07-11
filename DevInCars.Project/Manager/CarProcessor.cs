using DevInCars.Project.Domain;
using DevInCars.Project.Domain.Base;
using DevInCars.Project.Manager.Processors.Base;
using DevInCars.Project.Manager.Processors.Interfaces;

namespace DevInCars.Project.Manager;

public class CarProcessor : ProcessorBase<CarFactory>, IVehicleProcessor
{
    public VehicleManufactorInfo Constructor(VehicleFactoryBase constructor)
    {
        throw new NotImplementedException("Erro");
    }
}
    
