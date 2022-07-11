

using DevInCars.Project.Domain;
using DevInCars.Project.Domain.Base;

namespace DevInCars.Project.Database;

public class DataBase
{
    public List<CarFactory> Data = new List<CarFactory>();

    public void AddItem(CarFactory item)
    {
         Data.Add(item);
    }

    public void PrintData()
    {
        foreach (var item in Data)
        {
            Console.WriteLine($"{item.ChassisNumber}");
        }
    }
}