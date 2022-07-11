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
        var carCreation = new CarFactory(Guid.NewGuid(),new DateOnly(2022,07,23), "Punto", "xxx1234", 30.000, 40926280805, "Prata",
            1.6, FuelType.Gasolina, 4, VehicleStatus.Disponivel);

        var carInfo = CarProcessor.CreateCar1(carCreation);

        Console.WriteLine($"{carInfo.Vehicle.Color} {carInfo.Vehicle.ChassisNumber}");





    }
}