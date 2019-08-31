using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1
{
    class ejercicio2
    {
        static void Main(string[] args)
        {
            //Carrillos Gaitan
            Console.WriteLine("Este programa sirve para almacenar los datos de empleados.");
            string name, cargo, correo, date;
            int edad;
            float sueldo;
            Console.WriteLine("Ingrese el nombre del empleado: ");
            name = Console.ReadLine();
            Console.WriteLine("Ingrese el cargo del empleado: ");
            cargo = Console.ReadLine();
            Console.WriteLine("Ingrese correo del empleado: ");
            correo = Console.ReadLine();
            Console.WriteLine("Ingrese edad del empleado: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese fecha de contratación del empleado: ");
            date = Console.ReadLine();
            Console.WriteLine("Ingrese sueldo del empleado: ");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Nombre: " + name);
            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("Correo: " + correo);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Fecha de contratación: " + date);
            Console.WriteLine("Sueldo: $" + sueldo);
            Console.ReadKey();
        }
    }
}
