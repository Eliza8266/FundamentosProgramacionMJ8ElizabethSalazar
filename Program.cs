using System;

namespace _7.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//1. Escribir un algoritmo que permita generar los primeros 5 números enteros posibles y realizar y mostrar su suma.
            int contador = 1;
            int acumulador = 1;
            while (contador < 5)
            {
                contador ++;
                acumulador = acumulador + contador;
            }
            Console.WriteLine($"La suma de los primeros cinco números enteros positivos es: {acumulador}");*/

            //2. Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 5x4x3x2x1)
            int contador = 1;
            int acumulador = 1;
            int num = 0;
            Console.WriteLine("Ingrese un número entero para generar su factorial");
            num = int.Parse(Console.ReadLine());
            while (contador < num)
            {
                contador++;
            }

        }
    }
}
