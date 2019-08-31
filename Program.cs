using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            string nombre, especie;
            int edad;

            Console.Write("Este programa sirve para almacenar datos de su mascota");
            Console.WriteLine("");
            Console.Write("Ingrese el nombre de su mascota: ");
            nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Ingrese la especie de su mascota: ");
            especie = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Ingrese la edad de su mascota: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Clear();
            Console.Write("El nombre de su mascota es: " + nombre);
            Console.WriteLine("");
            Console.Write("La especie de su mascota es: " + especie);
            Console.WriteLine("");
            Console.Write("La edad de su mascota es: " + edad);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
