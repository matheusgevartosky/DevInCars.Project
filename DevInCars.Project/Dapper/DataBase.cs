using DevInCars.Project.Domain;
using DevInCars.Project.Domain.Base;
using DevInCars.Project.Domain.Entities;
using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Dapper;

public static class DataBase
{
    public static List<VehicleFactoryBase> Data = new()
    {
        new CarFactory(Guid.NewGuid(), new DateOnly(2013, 07, 23), "Punto", "xxx1234", 60.000,
            "Prata",
            1.6, FuelType.Gasolina, VehicleStatus.Disponivel, 1, VehicleType.Carro, "4", 4),
        new CarFactory(Guid.NewGuid(), new DateOnly(2018, 07, 23), "Prisma", "ABC1234", 30.000,
            "Preto",
            1.8, FuelType.Flex, VehicleStatus.Disponivel, 2, VehicleType.Carro, "2", 2)
    };

    public static List<Sales> SalesData = new();
}