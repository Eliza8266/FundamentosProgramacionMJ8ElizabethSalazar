using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Programacion_Modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
        }

        static float Suma()
        {
            float suma = 0;
            char respuesta = ' ';
            float numero = 0;
            do
            {
                Console.WriteLine("Ingrese un número:");
                numero=float.Parse(Console.ReadLine());
                suma+=numero;
                Console.WriteLine("desea seguir sumando(s: continuar");
                respuesta=char.Parse(Console.ReadLine());
            } while (respuesta=='s');
            return suma;
        }

        static void RealizarOperaciones(int opcion)
        {
            while (opcion!=0)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"la SUMA de los numeros ingresados es :{Suma()}");
                        break;
                    case 2:
                        Console.WriteLine("RESTA");
                        break;
                    case 3:
                        Console.WriteLine("MULTIPLICACIÓN");
                        break;
                    case 4:
                        Console.WriteLine("DIVISIÓN");
                        break;


                }
                Console.ReadKey();
                Console.Clear();
                MostrarMenu();
                opcion = CapturarOpcion();

            }
        }
        static int CapturarOpcion()
        {

            return int.Parse(Console.ReadLine());

        }
        static void MostrarMenu()
        {
            Console.WriteLine("------MENÚ------");
            Console.WriteLine("1.Suma   2.Resta");
            Console.WriteLine("3.Multiplicación   4.División");
            Console.WriteLine("0.salir");
            Console.WriteLine("----------------");
            Console.WriteLine("Ingrese una opción del menú:");
        }

    }
}
