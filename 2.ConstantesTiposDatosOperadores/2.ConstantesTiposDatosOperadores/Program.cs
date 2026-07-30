using System;

namespace _2.ConstantesTiposDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string iva="19%";
            string nombre = "Eliza";
            nombre = "Elizabeth";
            //iva = "20%"; a una constante no le puedo cambiar el valor
            //Tipos de datos
            byte dato1 = 255;
            int dato2 = -12365;
            long dato3 = 123565656;
            float dato4 = 5.3f;
            double dato5 = 12.36d;
            decimal dato6 = 125636.3265932363m;
            char dato7 = '¿'; //un solo caracter
            string dato8 = "dato8-*/*-969-*/*-'098765";
            bool dato9 = true; //ture or false
            object dato10 = new object();

            //OPERADORES
            //Operadores numericos
            //Cambio de signo
            int dato11 = 5;
            int dato12 = -dato11;
            Console.WriteLine("dato11: {0}, dato12:{1}", dato11, dato12);
            //Operadores aritmeticos
            int dato13 = 3 + 5;
            Console.WriteLine("La suma es: {0}", dato13);
            int dato14 = dato13 - 2;
            Console.WriteLine("La resta es: {0}", dato14);
            int dato15 = 3 * 5;
            Console.WriteLine("El producto es: {0}", dato15);
            //float dato16 =(float) 5 / 3;
            float dato16 = 5f / 3f;
            Console.WriteLine("La division es: {0}", dato16);
      




        }
    }
}
