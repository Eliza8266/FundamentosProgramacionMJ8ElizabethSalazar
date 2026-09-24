using System;

class Program
{
    static void Main(string[] args)
    {

        Random random = new Random();
        int numse = random.Next(1, 101);
        int intento = 0;

        while (intento != numse)
        {
            Console.Write("Adivina el número (1 - 100): ");
            intento = int.Parse(Console.ReadLine());

            if (intento > numse)
            {
                Console.WriteLine("Demasiado alto.");
            }
            else if (intento < numse)
            {
                Console.WriteLine("Demasiado bajo.");
            }
            else
            {
                Console.WriteLine("¡Correcto! Has adivinado el número.");
            }
        }
    }
}
