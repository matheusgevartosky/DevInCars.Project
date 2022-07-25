using System.Diagnostics;
using DevInCars.Project.Exceptions;
using DevInCars.Project.UI;

namespace DevInCars.Project;

internal class Program
{
    private static void Main()
    {
        var system = true;
        while (system)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n                        ---------Seja Bem Vindo Ao DevInCars!----------\n\n");
                Console.WriteLine(
                    " Selecione uma opção:\n\n" +
                    " 1 - Listas de Veículos Cadastrados\n" +
                    " 2 - Vender Veiculos\n" +
                    " 3 - Editar um Veículo cadastrado\n" +
                    " 4 - Sair\n\n");
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
                            SalesMenu.Sales();
                            break;
                        case 3:
                            EditVehicleMenu.Edit();
                            break;
                        case 4:
                            Console.WriteLine("Finalizando  o sistema...");
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