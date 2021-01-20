using System;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //area de un circulo:
            /* Console.WriteLine("ingrese el valor del radio para sacar el area del circulo");
             const double pi = 3.14;
             double radio = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("el área del cirulo es:" + pi * radio * radio); */

            //area de un hexagono:
            Console.WriteLine("ingrese el valor para sacar el perimetro de un hexagono");
            double L = Convert.ToDouble(Console.ReadLine());
            const double A = 5.2;
            double P = L * L;
            Console.WriteLine("el area del hexagono es:" + P * A / 2);
        }
    }
}
