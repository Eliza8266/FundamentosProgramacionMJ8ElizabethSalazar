using System;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita generar los 5 primeros números enteros y los sume. 1,2,3,4,5 suma=15

            //int contador = 1;
            int acumulador = 0;

            //Ciclo While

            /*while (contador<=5)
            {
                acumulador += contador;
                Console.WriteLine($"{contador} - {acumulador}");
                contador++;
            }*/

            //Do While

            /*do
            {
                acumulador += contador;
                Console.WriteLine($"{contador} - {acumulador}");
                contador++;

            } while (contador<=5);*/

            //For

            /*for (int contador=1;contador<=5;contador++)
            {
                acumulador += contador;
                Console.WriteLine($"{contador}-{acumulador}");
            }*/

            //Sumar numeros enteros positivos, hasta que el usuario ingrese un número negativo
            int numero = 0;
            
            /*while (numero>0)
            {
                acumulador += numero;
                Console.WriteLine("Ingrese un numero entero positivo. Negativo para salir");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"La suma de los números positivos ingresados es:{acumulador}");*/
            do
            {
                Console.WriteLine("Ingrese un numero entero positivo. Negativo para salir");
                numero=int.Parse( Console.ReadLine() );
                acumulador += numero;
            } while (numero>0);
            Console.WriteLine($"La suma de los números positivos ingresados es:{acumulador}");
        }
    }
}
