using System;

namespace segundo_intento
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.1416;

            int radio = 12;

            double area;

            radio = radio * radio;

            area = pi * radio;

            Console.WriteLine("El area del circulo es");
            Console.WriteLine(area);
        }
    }
}
