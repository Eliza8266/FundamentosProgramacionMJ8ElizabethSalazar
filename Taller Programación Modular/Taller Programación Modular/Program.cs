using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    /*static void Main()
    {
        string palabra = IngresarPalabra();

        char[] vector = ConvertirAVector(palabra);

        ContarVocalesYConsonantes(
            vector,
            out int vocales,
            out int consonantes
        );

        MostrarResultados(vocales, consonantes);
    }

    static string IngresarPalabra()
    {
        Console.Write("Ingrese una palabra: ");
        return Console.ReadLine() ?? "";
    }

    static char[] ConvertirAVector(string palabra)
    {
        return palabra.ToLower().ToCharArray();
    }

    static void ContarVocalesYConsonantes(
        char[] vector,
        out int vocales,
        out int consonantes)
    {
        vocales = 0;
        consonantes = 0;

        foreach (char letra in vector)
        {
            if (letra >= 'a' && letra <= 'z')
            {
                if ("aeiou".Contains(letra))
                    vocales++;
                else
                    consonantes++;
            }
        }
    }

    static void MostrarResultados(int vocales, int consonantes)
    {
        Console.WriteLine("Vocales: " + vocales);
        Console.WriteLine("Consonantes: " + consonantes);
    }*/



    static void Main()
    {
        List<string> tareas = new List<string>();
        int opcion;

        do
        {
            Console.WriteLine("\n--- LISTA DE TAREAS ---");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Eliminar tarea");
            Console.WriteLine("3. Mostrar tareas");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
                opcion = 0;

            switch (opcion)
            {
                case 1:
                    AgregarTarea(tareas);
                    break;

                case 2:
                    EliminarTarea(tareas);
                    break;

                case 3:
                    MostrarTareas(tareas);
                    break;

                case 4:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 4);
    }

    static void AgregarTarea(List<string> tareas)
    {
        Console.Write("Ingrese la tarea: ");
        string tarea = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(tarea))
        {
            Console.WriteLine("La tarea no puede estar vacía.");
            return;
        }

        tareas.Add(tarea);
        Console.WriteLine("Tarea agregada.");
    }

    static void EliminarTarea(List<string> tareas)
    {
        MostrarTareas(tareas);

        if (tareas.Count == 0)
            return;

        Console.Write("Ingrese el número de tarea a eliminar: ");

        if (int.TryParse(Console.ReadLine(), out int numero)
            && numero >= 1
            && numero <= tareas.Count)
        {
            tareas.RemoveAt(numero - 1);
            Console.WriteLine("Tarea eliminada.");
        }
        else
        {
            Console.WriteLine("Número inválido.");
        }
    }

    static void MostrarTareas(List<string> tareas)
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas registradas.");
            return;
        }

        for (int i = 0; i < tareas.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + tareas[i]);
        }
    }
}