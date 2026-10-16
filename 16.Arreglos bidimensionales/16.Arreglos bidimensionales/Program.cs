using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Arreglos_bidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,] numeros = new int[2,3];//el 2 numero de filas y el 3 es el numero de columnas
            //numeros[2, 1] = 45;no se puede almacenar porque el indice de la fila no existe 
            //numeros[1, 4] = 20; no se puede ya que la columna se desborda
            numeros[0, 0] = 12;
            numeros[1, 1] = 89;
            numeros[0, 2] = 46;
            numeros[1, 0] = 2;
            numeros[1, 1] = 54;
            numeros[1, 2] = 25;
            //recuperar dato de una posición
            Console.WriteLine($"El número almacenado en numeros[1,0] es :{numeros[1, 0]}");
            //recorrer matriz para llenar
            char[,]simbolos= new char[3,2];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)//recorrer las columnas 
                {
                    Console.WriteLine($"Escriba el caracter para la P[{i},{j}]");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }

            }

            //recorrer para recuperar los datos
            for (int i = 0; i < simbolos.GetLength(0); i++)
            {
                for (int j = 0; j < simbolos.GetLength(0); j++)
                {
                    Console.WriteLine($"{simbolos[i, j]}|");
                }
                Console.WriteLine();
            }

            //otra forma de declar e inicializar matrices 
            string[,] nombres = {
                                   {"Ana","alba","Carla","Juan" } ,
                                   {"Ferney","Guillermo","María","Carmenza" },
                                   {"Alejandro","Alex","Orlando","Pedro" }
                                 };*/


            //nuevo ejercicio , crear una matriz[10,20] , en cada posición de la matriz poner el número 100; mostrar la matriz en consola

        }
    }
}
