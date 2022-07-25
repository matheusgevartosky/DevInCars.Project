using DevInCars.Project.Domain.Base;
using DevInCars.Project.Domain.Entities;
using DevInCars.Project.Domain.Enum;
using DevInCars.Project.Exceptions;
using DevInCars.Project.UI;

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
    
    

    public static VehicleFactoryBase? ListVehicleById(int id)
    {
        try
        {
        var vehicleById = DataBase.Data.FirstOrDefault(x=>x.Id == id) ;
        if (vehicleById != null)
        {
            return vehicleById;
        }

        throw new InputException("Nenhum registro encontrado com o id informado. Tente Novamente.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            
        }
        return null;
    }


    public static List<VehicleFactoryBase> getVehicleByStatus()
    {
        try
        {
            List<VehicleFactoryBase> Avaliable = DataBase.Data.FindAll(x => x.Status == VehicleStatus.Disponivel);
            {
                return Avaliable;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public static void AddNewSale(Sales param)
    {
        DataBase.SalesData.Add(param);
    }

    public static List<Sales> ListAllSoldedVehicles()
    {
        return DataBase.SalesData;
    }

   

}   