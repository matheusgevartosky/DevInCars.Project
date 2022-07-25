using DevInCars.Project.Dapper;
using DevInCars.Project.Exceptions;

namespace DevInCars.Project.UI;

public static class EditVehicleMenu
{
    public static void Edit()
    {
        var controller = true;

        while (controller)
        {
            Console.Clear();
            Console.WriteLine("\n           ---------- Editar Veículos cadastrados ----------\n");
            try
            {
                Console.WriteLine("\nEscolha uma opção para seguir:\n" +
                                  " 1 - Editar Cor\n" +
                                  " 2 - Editar Valor\n" +
                                  " 3 - Voltar");

                Console.Write("Digite a opção escolhida (apenas o número):  ");
                var op = Console.ReadLine();

                bool sucess = int.TryParse(op, out var opcao);
                if (sucess)
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\n           ---------- Editar Cor cadastrada ----------\n");
                            Console.Write("Digite o id do veiculo que deseja alterar a cor: ");
                            var id = int.Parse(Console.ReadLine() ?? throw new InputException(
                                "Valor digitado incorreto ou inexistente. Tente Novamente"));
                            Console.Write("Digite a nova cor: ");
                            var color = Console.ReadLine() ?? throw new InputException(
                                "Valor digitado incorreto ou inexistente. Tente Novamente");
                            var dataColor = Services.ListVehicleById(id);
                            if (dataColor == null)
                            {
                                throw new InputException("Id não encontrado. Favor tentar novamente");
                            }

                            dataColor.Color = color;


                            Console.WriteLine($"Veículo editado!\n\n" +
                                              $"Veículo: {dataColor.Name}\n" +
                                              $"Cor: {dataColor.Color}\n");
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();

                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\n           ---------- Editar Valor cadastrada ----------\n");
                            Console.Write("Digite o id do veiculo que deseja alterar a cor: ");
                            var id2 = int.Parse(Console.ReadLine() ?? throw new InputException(
                                "Valor digitado incorreto ou inexistente. Tente Novamente"));
                            Console.Write("Digite o Novo valor: ");
                            var valor = int.Parse(Console.ReadLine());
                            var dataVAlue = Services.ListVehicleById(id2);
                            if (dataVAlue == null)
                            {
                                throw new InputException("Id não encontrado. Favor tentar novamente");
                            }

                            dataVAlue.Value = valor;


                            Console.WriteLine($" Veículo editado!\n\n" +
                                              $" Veículo: {dataVAlue.Name}\n" +
                                              $" Valor: R${dataVAlue.Value}\n");
                            Console.WriteLine(" Pressione qualquer tecla para continuar...");
                            Console.ReadKey();

                            break;
                        case 3:
                            controller = false;
                            return;
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