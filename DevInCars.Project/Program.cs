using DevInCars.Project.Database;
using DevInCars.Project.Domain;
using DevInCars.Project.Domain.Enum;
using DevInCars.Project.Manager;
using DevInCars.Project.Manager.Factory;

namespace DevInCars.Project;

internal class Program
{
    private static void Main()
    {
        var createCar = VehicleProcessorFactory.CreateVehicleProcessor(vehicleType: VehicleType.Carro);
        var carCreation = new CarFactory(Guid.NewGuid(), new DateOnly(2022, 07, 23), "Punto", "xxx1234", 30.000,
            "Prata",
            1.6, FuelType.Gasolina, VehicleStatus.Disponivel, 40926280805, 4);

        var carConstructor = new CarProcessor();
        var concreteCar = carConstructor.CreateCarAuth(carCreation);
        
        var teste = new DataBase();
        teste.PrintData();
    }
}