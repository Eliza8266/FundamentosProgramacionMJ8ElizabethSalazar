using System;

namespace _9.CiclosWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que le pida al ususario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de número que va a introducir
            //El algoritmo debe escribir en pantalla:
            // La cantidad de números introducidos que son mayores que 0
            // La cantidad de números introducidos menores que 0
            // La cantidad de números iguales a 0
            int cnum = 0;
            int num = 0;
            int numin = 0; //Contador números ingresados
            int cm = 0; //Contador números mayores
            int cme = 0; //Contador números menores
            int cmi = 0; //Contador números iguales
            Console.WriteLine("Ingrese la cantidad de números que va a introducir:");
            cnum = int.Parse(Console.ReadLine());
            while (numin < cnum)
            {
                numin++;
                Console.WriteLine("Ingrese el número");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    cm++;
                }
                else
                {
                    if (num < 0)
                    {
                        cme++;
                    }
                    else
                    {
                        cmi++;
                    }
                }
            }
            Console.WriteLine("La cantidad de números mayores a 0 ingresados son: " + cm);
            Console.WriteLine("La cantidad de números menores a 0 ingresados son: " + cme);
            Console.WriteLine("La cantidad de números iguales a 0 ingresados son: " + cmi);
        }
    }
}
