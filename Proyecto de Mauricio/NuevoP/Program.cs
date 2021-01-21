using System;

namespace NuevoP
{
    class Program
    {
        static void Main(string[] args)
        {
            Double r;
            Console.WriteLine("Ingresa un radio para que el valor del área del círculo sea 78.54:");
            r = Convert.ToDouble(Console.ReadLine());
            Double pi = 3.1416;
            Double r1;
            Double rf;
            string condicion;
            r1 = r * r;
            rf = r1 * pi;
            decimal p;
            p = Convert.ToDecimal(rf);
            p = Decimal.Round(p, 2);
            condicion = (p == 78.54M) ? "Felicidades, es correcto." : "Está mal, lo siento.";
            Console.WriteLine(condicion);

        }
    }
}
