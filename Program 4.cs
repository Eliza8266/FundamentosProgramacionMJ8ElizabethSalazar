using System;
using System.Security.Cryptography;

namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 0;
            do
            {
                acumulador += contador;
                contador++;
            } while (contador <= 5);
            Console.WriteLine($"La suma de los cinco primeros números es: {acumulador}");
            */
            int num;
            string desi;
            do
            {
                Console.WriteLine("Ingrese un número para generar su tabla de multiplicar (solo enteros postivos)");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"{num} x 1 = {num * 1}");
                Console.WriteLine($"{num} x 2 = {num * 2}");
                Console.WriteLine($"{num} x 3 = {num * 3}");
                Console.WriteLine($"{num} x 4 = {num * 4}");
                Console.WriteLine($"{num} x 5 = {num * 5}");
                Console.WriteLine($"{num} x 6 = {num * 6}");
                Console.WriteLine($"{num} x 7 = {num * 7}");
                Console.WriteLine($"{num} x 8 = {num * 8}");
                Console.WriteLine($"{num} x 9 = {num * 9}");
                Console.WriteLine($"{num} x 10 = {num * 10}");
                Console.WriteLine("Desea seguir generando tablas? (Responda Si o No, con mayúscula inicial)");
                desi = Console.ReadLine();
            } while (desi == "Si");
            Console.WriteLine("Operación finalizada");

        }
    }
}
