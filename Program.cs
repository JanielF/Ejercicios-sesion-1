using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1
            Console.Write("Porfavor ingresar nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Su nombre es : "+ nombre);


            //Ejercicio2
            var fecha = DateTime.Now;
            Console.WriteLine(fecha.ToString());

        }
    }
}