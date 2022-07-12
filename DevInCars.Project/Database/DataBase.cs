
using DevInCars.Project.Domain.Base;

namespace DevInCars.Project.Database;

public class DataBase
{
    public static List<VehicleFactoryBase> Data = new List<VehicleFactoryBase>();

    public static void AddItem(VehicleFactoryBase item)
    {
         Data.Add(item);
    }

    public static void PrintData()
    {
        foreach (var item in Data)
        {
            Console.WriteLine($"{item.Name} {item.Potency} {item.ChassisNumber}");
            
        }
    }
}