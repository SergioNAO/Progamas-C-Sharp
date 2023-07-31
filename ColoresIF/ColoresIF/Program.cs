using System;

namespace TablasMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un color (Amarillo, Morado, Rosa, Azul o Blanco): ");
            string color = Console.ReadLine().ToLower();

           if (color == "amarillo")
            {
                MostrarTablaMultiplicar(2);
            }
            else if (color == "morado")
            {
                MostrarTablaMultiplicar(7);
            }
            else if (color == "rosa")
            {
                MostrarTablaMultiplicar(9);
            }
            else if (color == "azul")
            {
                MostrarTablaMultiplicar(6);
            }
            else if (color == "blanco")
            {
                MostrarTablaMultiplicar(12);
            }
            else
            {
                Console.WriteLine("El color ingresado no es válido.");
            }
        }

        static void MostrarTablaMultiplicar(int numero)
        {
            Console.WriteLine($"Tabla del {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
