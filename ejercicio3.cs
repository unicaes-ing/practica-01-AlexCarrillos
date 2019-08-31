using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1
{
    class ejercicio3
    {
        static void Main(string[] args)
        {
            //Carrillos Gaitan

            float deci1, deci2, suma, resta, multiplicacion, div;
            Console.WriteLine("Ingrese el primer número decimal");
            deci1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número decimal");
            deci2 = float.Parse(Console.ReadLine());
            suma = deci1 + deci2;
            resta = deci1 - deci2;
            multiplicacion = deci1 * deci2;
            div = deci1 / deci2;
            Console.WriteLine("Sumatoria: " + string.Format("{0:0.0}", suma));
            Console.WriteLine("Resta: " + string.Format("{0:0.0}", resta));
            Console.WriteLine("Multiplicación: " + string.Format("{0:0.0}", multiplicacion));
            Console.WriteLine("División: " + string.Format("{0:0.0}", div));
            Console.ReadKey();
        }
    } 
}
