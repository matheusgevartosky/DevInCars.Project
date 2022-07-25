using DevInCars.Project.Exceptions;

namespace DevInCars.Project.Domain.Helpers;

public static class Helpers
{
    public static string? CpfValidator()
    {
        Console.WriteLine("Digigte o CPF do comprador");
        var data = Console.ReadLine();
        if (data != null && data.Length != 11)
        {
            throw new InputException("O CPF digitado é inválido");
        }

        return data;
    }
}