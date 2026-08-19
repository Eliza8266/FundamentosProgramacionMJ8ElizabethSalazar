using System;

namespace TallerCondicionalesElizabeth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si cuenta con munición y si se encuentra en estado invencible, crear un programa que:
            //a.Permita ingresar por teclado si el personaje está en estado invencible(True).
            //b.La cantidad de munición que tiene el personaje en el momento será calculada por el sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#. 
            // Ejemplo:
            /*  int numero;
              Random rnd = new Random();
              numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5
              Console.WriteLine(numero);
              c.Si el estado del personaje es invencible(true) y su cantidad de munición está entre 1 y 10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario no hacer nada.*/

            Console.WriteLine("¿El personaje esta en estado invencible (Escribe True or False)");
            string entrada = Console.ReadLine();
            bool esInvencible;

            bool.TryParse(entrada, out esInvencible);
            
            if(esInvencible == true)
            { 

            //b.La cantidad de munición se calcula por un número aleatorio.
            Random rnd = new Random();
            int municion = rnd.Next(0,11); //Devuelve un número entre 0 y 11

            Console.WriteLine($"[La munición generada por el sistema:{municion}]");

            //Si es invencible y su munición esta entre 1 y 10 dispara
            if (esInvencible == true && municion>=1 && municion<=10)
            {
                Console.WriteLine("El personaje está disparando");
            }

            }

        }
    }
}
