using System;

namespace _8.CicloWhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números integrados.
            int sumaEP = 0; //acumulador
            int num = 0;
            Console.WriteLine("Ingrese un número para sumar. Ingrese -1 para terminar.");
            num = int.Parse(Console.ReadLine());
            while (num>=0)
            {
                sumaEP += num;
                Console.WriteLine("Ingrese un número para sumar. Ingrese -1 para terminar.");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La suma de los números positivos ingresados es: " + sumaEP);


        }
    }
}
