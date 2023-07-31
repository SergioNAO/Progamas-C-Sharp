using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaColores_Swich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un color (Amarillo, Morado, Rosa, Azul o Blanco): ");
            string color = Console.ReadLine();

            switch (color.ToLower())
            {
                case "amarillo":
                    MostrarTablaMultiplicar(2);
                    break;
                case "morado":
                    MostrarTablaMultiplicar(7);
                    break;
                case "rosa":
                    MostrarTablaMultiplicar(9);
                    break;
                case "azul":
                    MostrarTablaMultiplicar(6);
                    break;
                case "blanco":
                    MostrarTablaMultiplicar(12);
                    break;
                default:
                    Console.WriteLine("El color ingresado no es válido.");
                    break;
            }
        }

        static void MostrarTablaMultiplicar(int numero)
        {
            Console.WriteLine($"Tabla del {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
            Console.ReadKey();
        }
    }
}
