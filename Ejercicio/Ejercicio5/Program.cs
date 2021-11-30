using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresar numero de la tabla ");
            int numero = Int32.Parse(Console.ReadLine());
            int contador = 10;
            for (int i = 1; i <= contador; i++)
            {

                Console.WriteLine( numero+"X"+i+"="+numero*i);
            }
            Console.ReadKey();
            
        }
    }
}
