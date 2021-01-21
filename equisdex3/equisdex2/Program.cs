using System;

namespace equisdex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            decimal area;

            string persona;

            decimal pi = 3.1416m;

            decimal radio;

            Console.WriteLine("Escribe un radio para que el area de un circulo sea 78.54");

            radio = Convert.ToDecimal(Console.ReadLine());

            radio = radio * radio;

            area = pi * radio;

            area = decimal.Round(area, 2);

            persona = (area == 78.54m) ? "awebo, eres un genio" : "nel, estas pendejo";

            Console.WriteLine(persona);
        }   
    }
}
