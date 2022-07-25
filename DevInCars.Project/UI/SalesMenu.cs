using DevInCars.Project.Dapper;
using DevInCars.Project.Domain.Base;
using DevInCars.Project.Domain.Entities;
using DevInCars.Project.Domain.Helpers;
using DevInCars.Project.Exceptions;

namespace DevInCars.Project.UI;

public static class SalesMenu
{
    public static void Sales()
    {
        var controller = true;

        while (controller)
        {
            Console.Clear();
            Console.WriteLine("\n           ---------- Vendas - Veículos cadastrados ----------\n");
            try
            {
                Console.WriteLine("\nEscolha uma opção para seguir:\n" +
                                  " 1 - Vender veículo\n" +
                                  " 2 - Listar veiculos disponíveis\n" +
                                  " 3 - Listar veículos vendidos \n" +
                                  " 4 - Listar veiculo vendido com o maior preço\n" +
                                  " 5 - Listar Veiculo  vendido com o menor Preço\n" +
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
                            Console.WriteLine("\n           ---------- Vender Veículo ----------\n");

                            Console.Write("Digite o id do veículo que será vendido: ");
                            var input = int.Parse(Console.ReadLine() ?? throw new InputException(
                                "Valor digitado incorreto ou inexistente. Tente Novamente"));;

                            VehicleFactoryBase? data = Services.ListVehicleById(input);
                            var cpf = Helpers.CpfValidator();

                            var venda = new Sales(data, cpf);

                            Services.AddNewSale(venda);
                            Console.WriteLine($"Nova venda efetuada!\n\n" +
                                              $"Veiculo: {venda.Vehicle.Name}\n" +
                                              $"Identificação do comprador: {venda.BuyerId}\n" +
                                              $"Valor: {venda.Vehicle.Value}\n");
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();

                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\n           ---------- Relatório - Veículos Disponíveis ----------\n");
                            try
                            {
                                var dataSales = Services.getVehicleByStatus();
                                if (dataSales.Count != 0)
                                {
                                    foreach (var item in dataSales)
                                    {
                                        Console.WriteLine($" Id: {item.Id} \n" +
                                                          $" Modelo: {item.Name}\n" +
                                                          $" Valor do veículo {item.Value}\n");
                                    }
                                }
                                else
                                {
                                    throw new InputException("Nenhum veículo Disponivel");
                                }
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
                            Console.WriteLine("\n           ---------- Relatório - Veículos Vendidos ----------\n");
                            try
                            {
                                var dataSales = Services.ListAllSoldedVehicles();
                                if (dataSales.Count != 0)
                                {
                                    foreach (var item in dataSales)
                                    {
                                        Console.WriteLine($" Modelo: {item.Vehicle.Name} \n" +
                                                          $" Cpf do Comprador: {item.BuyerId}\n" +
                                                          $" Data da Venda: {item.SaleDate} \n" +
                                                          $" Valor do veículo {item.SaleValue}\n");
                                    }
                                }
                                else
                                {
                                    throw new InputException("Nenhum veículo vendido");
                                }
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
                            Console.WriteLine(
                                "\n           ---------- Relatório - Veículo Vendido com maior valor ----------\n");
                            try
                            {
                                var dataSales = Services.ListAllSoldedVehicles();
                                var max = dataSales.Max(x => x.Vehicle.Value);
                                
                                if (dataSales.Count != 0)
                                {
                                    Console.WriteLine($" O Maioroooo Valor foi de : {max} \n");

                                }
                                else
                                {
                                    throw new InputException("Nenhum veículo vendido");
                                }
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
                                "\n           ---------- Relatório - Veículo Vendido com menor valor ----------\n");
                            try
                            {
                                var dataSales = Services.ListAllSoldedVehicles();
                                var min = dataSales.Min(x => x.Vehicle.Value);
                                if (dataSales.Count != 0)
                                {
                                    Console.WriteLine($" O Menor Valor Foi De: {min} \n");

                                }
                                else
                                {
                                    throw new InputException("Nenhum veículo vendido");
                                }
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
                            throw new InputException("A opção digitada não existe ou é inválida! Escolha novamente");
                    }
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