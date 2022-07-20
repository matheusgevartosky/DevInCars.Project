using System.Diagnostics;
using DevInCars.Project.Domain;
using DevInCars.Project.Domain.Enum;
using DevInCars.Project.Domain.UI;
using DevInCars.Project.Manager;
using DevInCars.Project.Manager.Factory;
using static DevInCars.Project.Dapper.Services;

namespace DevInCars.Project;

internal class Program
{
    private static void Main()
    {
        /* var vehicleFactoryBase = new CarFactory(Guid.NewGuid(), new DateOnly(2022, 07, 23), "Punto", "xxx1234", 30.000,
            "Prata",
            1.6, FuelType.Gasolina, VehicleStatus.Disponivel,DataBase.Data.Count +1 , 40926280805, 4);
        var carData = vehicleFactoryBase;
        
        var createCar = VehicleProcessorFactory.CreateVehicleProcessor(vehicleType: VehicleType.Carro);
        createCar.CreateVehicle(carData);

        var teste = ListAll();
        var tt2 = teste.Max(x => x.Value);
        var t3 = teste.Min(x => x.Value);

        Console.WriteLine($"maior: {tt2}\n menor:;{t3}");

        foreach (var item in teste)
        {
            Console.WriteLine($"{item.Name} {item.Type}");
        }*/
        
        Menu.MainMenu();
        
    }
}