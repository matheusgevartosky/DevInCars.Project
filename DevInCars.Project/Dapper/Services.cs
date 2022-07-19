using DevInCars.Project.Domain.Base;
using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Dapper;

public class Services
{
    public static List<VehicleFactoryBase> ListAll()
    {
        return DataBase.Data;
    }

    public static List<VehicleFactoryBase>? ListVehicleType(VehicleType vehicleType)
    {
        switch (vehicleType)
        {
            case VehicleType.Carro:
                return DataBase.Data.FindAll(x => x.Type == VehicleType.Carro);
            case VehicleType.Caminhonete:
                return DataBase.Data.FindAll(x => x.Type == VehicleType.Caminhonete);
            case VehicleType.Moto:
                return DataBase.Data.FindAll(x => x.Type == VehicleType.Moto);
            case VehicleType.Triciculo:
               return DataBase.Data.FindAll(x => x.Type == VehicleType.Triciculo);
            default:
                Console.WriteLine("Tipo não cadastrado");
                break;
        }

        return null;
    }

    public static List<VehicleFactoryBase> ListAllAvailableVehicles()
    {
        var availableVehicles = DataBase.Data.FindAll(x => x.Status == VehicleStatus.Disponivel);
        return availableVehicles;
    }

    public static List<VehicleFactoryBase> ListAllSoldVehicles()
    {
        var soldVehicles = DataBase.Data.FindAll(x => x.Status == VehicleStatus.Vendido);
        return soldVehicles;
    }
}