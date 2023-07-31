using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es par.");
            }
            else
            {
                Console.WriteLine($"El número {numero} es impar.");
            }
        }
    }
}
