using System;
namespace _12.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int numcu;
            float saldo;
            int cont = 0;
            float acum = 0;
            string res;
            float prom;
            do
            {
                cont++;
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el número de su cuenta");
                numcu = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el saldo de su cuenta");
                saldo = float.Parse(Console.ReadLine());
                acum += saldo;
                if (saldo >= 3000000)
                {
                    Console.WriteLine($"Nombre: {nombre}");
                    Console.WriteLine($"Número de cuenta: {numcu}");
                    Console.WriteLine($"Saldo: {saldo}");
                    Console.WriteLine("Usted es apto para el crédito.");
                }
                else
                {
                    Console.WriteLine($"Nombre: {nombre}");
                    Console.WriteLine($"Número de cuenta: {numcu}");
                    Console.WriteLine($"Saldo: {saldo}");
                    Console.WriteLine("Usted no es apto para el crédito.");
                }
                Console.WriteLine("¿Desea agregar otro usuario? (Si o No, con mayúscula inicial)");
                res = Console.ReadLine();
            } while (res == "Si");
            Console.WriteLine($"La cantidad de usuarios a la que se le preguntó fue: {cont}");
            prom = acum / cont;
            Console.WriteLine($"El promedio de los saldos ingresados es: {prom}");
        }
    }
}
