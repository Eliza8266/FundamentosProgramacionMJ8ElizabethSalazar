using System;

namespace Parcial2Programación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El almacén "La Fama" cuenta con los registros del número de ventas realizadas durante cada uno de los 12 meses del año anterior.Se requiere diseñar un programa que procese esta información para evaluar el desempeño anual del negocio.

            int totalVentas = 0;

            int maxVentas = int.MinValue;
            int minVentas = int.MaxValue;

            int mesMax = 0;
            int mesMin = 0;
           

            Console.WriteLine("---------------Registro anual del almacén La fama---------------");
            int mes;
            //1.Ingreso de Datos(Estructura repetitiva)
            for ( mes = 1; mes <= 12; mes++) 
            {
                Console.WriteLine($"Ingrese el número de ventas del mes{mes}:");
                int ventas = int.Parse( Console.ReadLine() );

            //2.Cálculo del Promedio (Acumular el total)
                totalVentas += ventas;

                //3.Identificación de Extremos (Mayor Venta)
                if (ventas > maxVentas)
                {
                    maxVentas = ventas;
                    mesMax = mes; 

                }
                //3.Identificación de Extremos (Menor Venta)
                if (ventas < minVentas)
                {
                    minVentas = ventas;
                    mesMin = mes;
                }
            }
            double promedio = (double)totalVentas / 12;

            //Reporte Final 
            Console.WriteLine("\n-------REPORTE FINAL-------");
            Console.WriteLine($"Promedio anual de ventas: {promedio:F2}");
            Console.WriteLine($"El mes con mayor número de ventas fue el mes: {mesMax} con {maxVentas} ventas.");
            Console.WriteLine($"El mes con menor número de ventas fue el mes: {mesMin} con {minVentas} ventas.");

            //Evaluación de Metas (Condicional)
            if (promedio > 500)
            {
                Console.WriteLine("Se aprobó la meta.");
            }
            else
            {
                Console.WriteLine("La meta de ventas no se cumplió.");
            }

        }
    }
}
