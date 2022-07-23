using System.Diagnostics;
using DevInCars.Project.Dapper;
using DevInCars.Project.Exceptions;

namespace DevInCars.Project.UI;

public static class Menu
{
    static bool _controller = true;


    public static void ListsMenu()
    {
        while (_controller)
        {
            Console.Clear();
            Console.WriteLine("\n           ----------Listas - DevInCars ----------\n");
            try
            {
                Console.WriteLine("\nEscolha uma lista de veículos de para exibir\n" +
                                  "1 - Listar Todos os Veículos\n" +
                                  "2 - Listar Todos os Carros\n" +
                                  "3 - Listar Todas as Caminhonetes\n" +
                                  "4 - Listar Todas as Motos/Triciculos\n" +
                                  "5 - Voltar\n");

                Console.Write("Digite a opção escolhida (apenas o número):  ");
                var op = Console.ReadLine();

                bool sucess = int.TryParse(op, out var opcao);

                if (sucess)
                {
                    switch (opcao)
                    {
                        case 1:
                            var data = Services.ListAll();
                            foreach (var item in data)
                            {
                                Console.WriteLine($"Id:  {item.Id}\n" +
                                                  $"Modelo:  {item.Name}\n" +
                                                  $"Data de Fabricação: {item.ManufacturingDate}");
                            }

                            Console.ReadKey();

                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            _controller = false;
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
                throw;
            }
        }
    }
}