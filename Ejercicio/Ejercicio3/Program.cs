using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main()
        {
            int dtUno, dtDos, rt;
            Console.WriteLine("Registrar Primer dato");
            dtUno = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Registar Segundo Dato ");
            dtDos = Int32.Parse(Console.ReadLine());
            rt = dtUno + dtDos;
            Console.WriteLine("El resultado de la operacion es :" + rt);
            Console.ReadKey();
        }
    }
}
