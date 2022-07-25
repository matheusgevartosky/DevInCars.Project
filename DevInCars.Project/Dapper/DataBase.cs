using DevInCars.Project.Domain;
using DevInCars.Project.Domain.Base;
using DevInCars.Project.Domain.Entities;
using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Dapper;

public static class DataBase
{
    public static List<VehicleFactoryBase> Data = new()
    {
        new CarFactory(Guid.NewGuid(), new DateOnly(2013, 07, 23), "Punto", "xxx1234", 60000.00,
            "Prata",
            1.6, FuelType.Gasolina, VehicleStatus.Disponivel, 1, VehicleType.Carro, "0", 4),
        new CarFactory(Guid.NewGuid(), new DateOnly(2018, 07, 23), "Prisma", "ABC1234", 30000.00,
            "Preto",
            1.8, FuelType.Flex, VehicleStatus.Disponivel, 2, VehicleType.Carro, "0", 2),
        new TruckFactory(Guid.NewGuid(),new DateOnly(2000, 07, 23), "Silverado", "AYI3387", 50000.00,3.00, FuelType.Disel, VehicleStatus.Disponivel, 3, VehicleType.Caminhonete,850,"0", 2),
        new TruckFactory(Guid.NewGuid(),new DateOnly(2022, 07, 23), "Toro", "WAV7777", 150000.00,1.8, FuelType.Gasolina, VehicleStatus.Disponivel, 4, VehicleType.Caminhonete,1000, "0", 4),
        new MotorcycleFactory(Guid.NewGuid(),new DateOnly(2015, 07, 23), "CG Titan", "ABC1598", 8000.00, "Preta", 150, FuelType.Gasolina, VehicleStatus.Disponivel,5, VehicleType.Moto,"0" , 2),
        new MotorcycleFactory(Guid.NewGuid(),new DateOnly(2000, 07, 23), "750 Four", "ABC1598", 50000.00, "Preta", 750, FuelType.Gasolina, VehicleStatus.Disponivel,6, VehicleType.Moto,"0" ,2),
        new MotorcycleFactory(Guid.NewGuid(),new DateOnly(2022, 07, 23), "Hayabusa", "ABC1598", 45000.00, "Preta", 1200, FuelType.Gasolina, VehicleStatus.Disponivel,7, VehicleType.Moto,"0",2),
        new CarFactory(Guid.NewGuid(), new DateOnly(1980, 07, 23), "Corcel", "ABC9994", 30000.00,
            "Vermelho",
            1.8, FuelType.Gasolina, VehicleStatus.Disponivel, 8, VehicleType.Carro, "0", 2),
        new CarFactory(Guid.NewGuid(), new DateOnly(1968, 07, 23), "Fusca", "ABC0666", 30000.00,
            "Azulo",
            1.8, FuelType.Gasolina, VehicleStatus.Disponivel, 9, VehicleType.Carro, "0", 2),
            
    };

    public static List<Sales> SalesData = new();
}