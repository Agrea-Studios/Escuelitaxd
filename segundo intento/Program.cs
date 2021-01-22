using System;

namespace segundo_intento
{
    class Program
    {
        static void Main(string[] args)
        {
           
            decimal x;

            decimal pi = 3.1416m;

            Console.WriteLine("ingresar el valor para que el area de un circulo sea 113 o 53.93");

            x = Convert.ToDecimal(Console.ReadLine());

            decimal area;

            x = x * x;

            area = x * pi;

            area = decimal.Round(area, 2);

            switch (area)
            {
                case 153.94m:
                Console.WriteLine("en efecto, es 113.10");
                break;

                case 113.10m:
                Console.WriteLine("no pos equisde");
                break;

                case 78.54m:
                Console.WriteLine("al chile tu resultado es 78.54");
                break;

                default:
                Console.WriteLine("es falsooooooooo");
                break;

            }

        }
    }
}
