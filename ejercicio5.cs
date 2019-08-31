using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1
{
    class ejercicio5
    {
        static void Main(string[] args)
        {

            //Carrillos Gaitan
            float trimestre1, trimestre2, trimestre3, trimestre4, prome;
            Console.WriteLine("Ingrese el total de ventas del año");
            Console.WriteLine("=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            Console.WriteLine("=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            Console.WriteLine("Ingrese el total de ventas del Trimestre #1");
            trimestre1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total de ventas del Trimestre #2");
            trimestre2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total de ventas del Trimestre #3");
            trimestre3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total de ventas del Trimestre #4");
            trimestre4 = float.Parse(Console.ReadLine());
            prome = (trimestre1 + trimestre2 + trimestre3 + trimestre4) / 4;
            Console.WriteLine("=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            Console.WriteLine("=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            Console.WriteLine("Promedio Total de Ventas del Año es: $" + prome);
            Console.ReadKey();
        }
    }
}
