using DevInCars.Project.Domain.Enum;

namespace DevInCars.Project.Domain.UI;

public static class Menu
{
    public static void MainMenu()
    {
        Console.WriteLine("Seja bem vindo! Selecione a operação que deseja efetuar " +
                          "1 - Listar Veiculos " +
                          "2 - Vender Veiculos" +
                          "3 - Cadastrar Veiculos" 
                          );
        
        var option = Console.ReadLine();
        
        switch (option)
        {
            case "1":
                
                break;
                
        }
    }

    
}