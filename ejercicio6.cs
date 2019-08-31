using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1
{
    class ejercicio6
    {
        static void Main(string[] args)
        {
            //Carrillos Gaitan
            string name;
            double sueldo, isss, renta, afp;
            Console.WriteLine("Ingrese el nombre del empleado");
            name = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado");
            sueldo = float.Parse(Console.ReadLine());
            isss = sueldo * 0.080;
            afp = sueldo * 0.080;
            renta = sueldo * 0.2;
            sueldo = sueldo - isss - afp - renta;
            Console.WriteLine("Sueldo a pagar al empleado: " + sueldo.ToString("C"));
            Console.WriteLine("Descuentos");
            Console.WriteLine("ISSS: " + isss.ToString("C"));
            Console.WriteLine("AFP: " + afp.ToString("C"));
            Console.WriteLine("Renta: " + renta.ToString("C"));
            Console.ReadKey();
        }
    }
}
