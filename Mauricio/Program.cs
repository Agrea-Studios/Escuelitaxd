using System;

namespace Mauricio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un valor:");
            Double pi = 3.1416;
            Double r;
            Double r1;
            Double rf;
            r = Convert.ToDouble(Console.ReadLine());
            r1 = r * r;
            rf = r1 * pi;
            Console.WriteLine("El area es:"+ rf);

        }
    }
}
