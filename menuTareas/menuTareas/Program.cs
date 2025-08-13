using System;
using System.Collections.Generic;

class Program
{
    static readonly List<string> tareas = new List<string>();

    static void Main()
    {
        while (true)
        {
            MostrarMenu();
            Console.Write("Elige una opción: ");
            string opcion = Console.ReadLine()?.Trim();

            switch (opcion)
            {
                case "1":
                    AgregarTarea();
                    break;
                case "2":
                    VerTareas();
                    break;
                case "3":
                    EliminarTarea();
                    break;
                case "4":
                    Console.WriteLine("¡Adiós!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("===== Menú de Tareas =====");
        Console.WriteLine("1. Agregar tarea");
        Console.WriteLine("2. Ver tareas");
        Console.WriteLine("3. Eliminar tarea");
        Console.WriteLine("4. Salir");
    }

    static void AgregarTarea()
    {
        Console.Write("Ingresa la tarea: ");
        string tarea = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(tarea))
        {
            Console.WriteLine("No puedes agregar una tarea vacía.");
            return;
        }

        tareas.Add(tarea);
        Console.WriteLine("Tarea agregada.");
    }

    static void VerTareas()
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas.");
            return;
        }

        Console.WriteLine("===== Tus tareas =====");
        for (int i = 0; i < tareas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tareas[i]}");
        }
    }

    static void EliminarTarea()
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas para eliminar.");
            return;
        }

        VerTareas();
        Console.Write("Número de la tarea a eliminar: ");
        string entrada = Console.ReadLine()?.Trim();

        if (!int.TryParse(entrada, out int numero) || numero < 1 || numero > tareas.Count)
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        string eliminada = tareas[numero - 1];
        tareas.RemoveAt(numero - 1);
        Console.WriteLine($"Tarea eliminada: {eliminada}");
    }
}
