using System;

namespace InversionCadenaTextoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el texto que deseas invertir: ");
            string textoIngresado = Console.ReadLine();

            char[] arregloCaracteres = textoIngresado.ToCharArray();
            Array.Reverse(arregloCaracteres);

            string resultadoInversion = new string(arregloCaracteres);

            Console.WriteLine("Resultado de la inversión: " + resultadoInversion);
        }
    }
}
