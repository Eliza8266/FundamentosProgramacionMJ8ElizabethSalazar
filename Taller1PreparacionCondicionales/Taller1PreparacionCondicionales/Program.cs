using System;

namespace Taller1PreparacionCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son diferentes, si es así,imprimir cual es el número mayor, además ordenar y mostrar en pantalla los números de menor a mayor.

            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;
            int mayor = 0;
            int medio = 0;
            int menor = 0;

            Console.WriteLine("Ingrese el número 1");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 3");
            numero3 = int.Parse(Console.ReadLine());

            if (numero1 != numero2 && numero1!=numero3 && numero2!=numero3)
            {
                //verdadero
                if (numero1 > numero2 && numero1 > numero3)
                {
                    
                    mayor = numero1;
                    if (numero2 > numero3)
                    {
                        medio= numero2;
                        menor= numero3;
                        Console.WriteLine($"Mayor: {numero1}, medio: {numero2}, menor: {numero3}");
                    }
                    else 
                    {
                        medio = numero3;
                        menor= numero2;
                        Console.WriteLine($"Mayor: {numero1}, medio: {numero3}, menor: {numero2}");
                    } 

                }
                if (numero2 > numero1 && numero2 > numero3)
                {

                    mayor = numero2;
                    if(numero1>numero3)
                    {
                        medio = numero1;
                        menor = numero3;

                        Console.WriteLine($"Mayor: {numero2}, medio: {numero1}, menor: {numero3}");

                    }
                    else
                    {
                        medio = numero3;
                        menor = numero1;
                        Console.WriteLine($"Mayor: {numero2}, medio: {numero3}, menor: {numero1}");
                    }
                }
                if (numero3 > numero1 && numero3 > numero2)
                {
                    mayor = numero3;
                    if(numero2 > numero1)
                    {
                        medio = numero2;
                        menor = numero1;
                        Console.WriteLine($"Mayor: {numero3}, medio: {numero2}, menor: {numero1}");
                    }
                    else
                    {
                        medio = numero1;
                        menor = numero2;
                        Console.WriteLine($"Mayor: {numero3}, medio: {numero1}, menor: {numero2}");
                    }

                }
            }
            else 
            { 
                //Falsa
                Console.WriteLine("Los números deben ser diferentes");
            }
           
            



        }
        
    }
}
