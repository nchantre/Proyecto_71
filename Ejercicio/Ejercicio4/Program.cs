using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main()
        {
        
            Console.WriteLine("***************");
            Console.WriteLine("Registar edad");
            var edad = Int32.Parse(Console.ReadLine());
            if (edad>= 18)
            {
                Console.WriteLine("soy mayor de edad");
            }
            else
            {
                Console.WriteLine("soy menor de edad");
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
