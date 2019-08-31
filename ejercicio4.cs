using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1
{
    class ejercicio4
    {
        static void Main(string[] args)
        {
            //Carrillos Gaitan
            uint numero;
            double res;
            Console.WriteLine("Escriba un número entero positivo");
            numero = Convert.ToUInt32(Console.ReadLine());
            res = Math.Sqrt(numero);
            Console.WriteLine("La raíz cuadrada del número ingresado es " + res);
            Console.ReadKey();
        }
    }
}
