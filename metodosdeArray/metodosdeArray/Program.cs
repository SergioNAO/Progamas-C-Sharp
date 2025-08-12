using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa números separados por coma: ");
        string entrada = Console.ReadLine();

        // Validación y conversión
        int[] numeros;
        try
        {
            numeros = entrada.Split(',')
                             .Select(n => int.Parse(n.Trim()))
                             .ToArray();
        }
        catch
        {
            Console.WriteLine("Error: Debes ingresar solo números separados por coma.");
            return;
        }

        // Cálculos
        int mayor = numeros.Max();
        int menor = numeros.Min();
        double promedio = numeros.Average();
        int[] ordenados = numeros.OrderBy(n => n).ToArray();

        // Resultados
        Console.WriteLine($"Número mayor: {mayor}");
        Console.WriteLine($"Número menor: {menor}");
        Console.WriteLine($"Promedio: {promedio}");
        Console.WriteLine("Ordenados: " + string.Join(", ", ordenados));
    }
}
