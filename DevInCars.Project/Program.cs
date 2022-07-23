using System.Diagnostics;
using DevInCars.Project.Exceptions;
using DevInCars.Project.UI;

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
        }
    }*/
        Console.Clear();
        Console.WriteLine("\n                        ---------Seja Bem Vindo Ao DevInCars!----------\n\n");
        var system = true;
        while (system)
        {
            try
            {
                
                Console.WriteLine( 
                                  "Selecione uma opção:\n" +
                                  "1 - Listas de Veículos Cadastrados" +
                                  "2 - Vender Veiculos" +
                                  "3 - Editar um Veículo cadastrado" +
                                  "4 - Sair");
                Console.Write("Digite a opção escolhida (apenas o número):  ");
                var op = Console.ReadLine();

                bool sucess = int.TryParse(op, out var opcao);

                if (sucess)
                {
                    switch (opcao)
                    {
                        case 1:
                            Menu.ListsMenu();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            system = false;
                            return;

                        default:
                            throw new InputException("A opção digitada não existe ou é inválida! Escolha novamente");
                    }
                }
                else
                {
                    throw new InputException("A opção digitada não existe ou é inválida! Escolha novamente");
                }

            }
            catch
                (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

