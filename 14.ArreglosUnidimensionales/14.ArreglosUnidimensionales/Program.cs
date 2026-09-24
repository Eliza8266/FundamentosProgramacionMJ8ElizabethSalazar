using System;

namespace _14.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            //Arreglos Unidimensionales o ventor
                        int[] numeros = new int[5];
                        numeros[0]=15;
                        numeros[1]=56;
                        numeros[2]=20;
                        numeros[3]=47;
                        numeros[4]=27;
                        //numeros[5] = 100; no es posible porque la posición 6 con indice 5 no existe
                        Console.WriteLine($"El dato almacenado en la posición 4 con índice 3 es: {numeros[3]}");

                        float[] notas = new float[3];
                        notas[0] = 3.6f;
                        notas[1] = 4.3f;
                        notas[2] = 5.0f;
                        //Otras formas de declarar e inicializar
                        char[] simbolos= new char[] { '?', '(', '5', 'f' };
                        bool[] valoresVerdad = { true, false, true, true, false };

                        //Recorrer un vector para llenarlo de datos
                        string[] nombres = new string[7];

                        for( int i = 0; i <7; i ++)
                        {
                            Console.WriteLine($"Ingrese el nombre para la P{i+1}:I{i}");
                            nombres[i]=Console.ReadLine();
                        }

                        //Recorrer el vector para recuperar los datos almacenados en el vector
                        for( int i = 0; i < nombres.Length;i ++)
                        {
                            Console.Write($"{nombres[i]} |");
                        }*/


            //Crear arreglo llamado "enteros" de 100 elementos asignar el número 10 en cada una de las posiciones del arreglo.Leer el contenido de cada elemento y mostrarlo en pantalla.
            int[] enteros = new int[100];

           
            for (int i = 0; i < enteros.Length; i++)
            {
                enteros[i] = 10;
            }

            for (int i = 0; i< enteros.Length; i++)
            {
                Console.WriteLine($"Posición {i}: {enteros[i]}");
            }


            
        }
    }
}
