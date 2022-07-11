using DevInCars.Project.Database;
using DevInCars.Project.Domain;
using DevInCars.Project.Domain.Base;
using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Manager.Processors.Base;

public abstract class ProcessorBase<T> where T : VehicleFactoryBase
{
    protected static T ValidateVehicleType(VehicleFactoryBase vehicle)
    {
        if (!(vehicle is T)) throw new ArgumentException("Tipo de veiculo inválido!");
        
        var teste = new DataBase();
        teste.AddItem((CarFactory)vehicle);
        return (T)vehicle;
    }
}