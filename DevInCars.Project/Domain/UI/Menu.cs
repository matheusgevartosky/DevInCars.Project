using System.Resources;
using DevInCars.Project.Dapper;
using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Domain.UI;

public static class Menu
{
    public static void MainMenu()
    {
        Console.WriteLine("Seja bem vindo! Selecione a operação que deseja efetuar \n" +
                          "1 - Listar Veiculos \n" +
                          "2 - Vender Veiculos \n" +
                          "3 - Cadastrar Veiculos \n"
                          );
        
        var option = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        
        switch (option)
        {
            case 1:
                    Lists();
                break;
                
        }
    }

    public static void Lists()
    {
        Console.WriteLine("\nEscolha uma opção para listar:\n" + 
                          "\n1 - Listar todos os veículos\n"+
                          "2 - Listar veículos disponíveis\n" + 
                          "3 - Listar veculos vendidos\n" +
                          "4 - Listar por modelo\n\n"
                          );

        Console.Write("Digite a opção desejada");
        var option = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        try
        {
            switch (option)
            {
                case 1:
                    var data = Services.ListAll();
                    foreach (var item in data)
                    {
                        Console.WriteLine($"{item.Id} | {item.Name} | {item.Potency} | {item.Type}");
                    }
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    
    

    
}