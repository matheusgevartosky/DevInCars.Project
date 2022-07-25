using System.Diagnostics;
using DevInCars.Project.Dapper;
using DevInCars.Project.Domain.Enum;
using DevInCars.Project.Exceptions;

namespace DevInCars.Project.UI;

public static class Menu
{
    public static void ListsMenu()
    {
        var controller = true;

        while (controller)
        {
            Console.Clear();
            Console.WriteLine("\n           ---------- Relatórios - DevInCars ----------\n");
            try
            {
                Console.WriteLine("\n Escolha um relatório para exibir:\n" +
                                  "\n 1 - Listar Todos os Veículos\n" +
                                  " 2 - Listar Todos os Carros\n" +
                                  " 3 - Listar Todas as Caminhonetes\n" +
                                  " 4 - Listar Todas as Motos\n" +
                                  " 5 - Listar Todos os Triciculos\n" +
                                  " 6 - Voltar\n");

                Console.Write("Digite a opção escolhida (apenas o número):  ");
                var op = Console.ReadLine();

                bool sucess = int.TryParse(op, out var opcao);

                if (sucess)
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\n           ---------- Relatório - Veículos cadastrados ----------\n");
                            var data = Services.ListAll();
                            foreach (var item in data)
                            {
                                Console.WriteLine($"Id:  {item.Id}\n" +
                                                  $"Modelo:  {item.Name}\n" +
                                                  $"Data de Fabricação: {item.ManufacturingDate}\n" +
                                                  $"Valor: {item.Value}\n\n");
                            }

                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();

                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\n           ---------- Relatório - Carros cadastrados ----------\n");

                            try
                            {
                                var dataCars = Services.ListVehicleType(VehicleType.Carro);

                                if (dataCars != null && dataCars.Count != 0)
                                {
                                    foreach (var item in dataCars)
                                    {
                                        Console.WriteLine($"Id:  {item.Id}\n" +
                                                          $"Modelo:  {item.Name}\n" +
                                                          $"Data de Fabricação: {item.ManufacturingDate}\n" +
                                                          $"Valor: {item.Value}\n\n");
                                    }
                                }
                                else
                                    throw new Exception("Nenhum carro cadastrado");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine(
                                "\n           ---------- Relatório - Caminhonetes cadastradas ----------\n");

                            try
                            {
                                var dataTruck = Services.ListVehicleType(VehicleType.Caminhonete);

                                if (dataTruck != null && dataTruck.Count != 0)
                                {
                                    foreach (var item in dataTruck)
                                    {
                                        Console.WriteLine($"Id:  {item.Id}\n" +
                                                          $"Modelo:  {item.Name}\n" +
                                                          $"Data de Fabricação: {item.ManufacturingDate}\n" +
                                                          $"Valor: {item.Value}\n\n");
                                    }
                                }
                                else
                                    throw new Exception("Nenhuma Caminhonete cadastrada");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("\n           ---------- Relatório - Motos cadastradas ----------\n");

                            try
                            {
                                var dataMotorcycle = Services.ListVehicleType(VehicleType.Moto);

                                if (dataMotorcycle != null && dataMotorcycle.Count != 0)
                                {
                                    foreach (var item in dataMotorcycle)
                                    {
                                        Console.WriteLine($"Id:  {item.Id}\n" +
                                                          $"Modelo:  {item.Name}\n" +
                                                          $"Data de Fabricação: {item.ManufacturingDate}\n" +
                                                          $"Valor: {item.Value}\n");
                                    }
                                }
                                else
                                    throw new Exception("Nenhuma Moto cadastrada");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine(
                                "\n           ---------- Relatório - Triciculos cadastrados ----------\n");

                            try
                            {
                                var dataTricycle = Services.ListVehicleType(VehicleType.Triciculo);

                                if (dataTricycle != null && dataTricycle.Count != 0)
                                {
                                    foreach (var item in dataTricycle)
                                    {
                                        Console.WriteLine($"Id:  {item.Id}\n" +
                                                          $"Modelo:  {item.Name}\n" +
                                                          $"Data de Fabricação: {item.ManufacturingDate}\n" +
                                                          $"Valor: {item.Value}\n");
                                    }
                                }
                                else
                                    throw new Exception("Nenhum tricículo cadastrado");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            break;
                        case 6:
                            controller = false;
                            return;
                        default:
                            throw new InputException(
                                "\nA opção digitada não existe ou é inválida! Escolha novamente\n");
                    }
                }
                else
                {
                    throw new InputException("\nA opção digitada não existe ou é inválida! Escolha novamente\n");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}