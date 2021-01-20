using System;

namespace Mauricio
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
            Double r2,rf2,x=5;
            r2 = x * x;
            rf2 = r2 * pi; 
            r1 = r * r;
            rf = r1 * pi;
            if(rf == rf2){ Console.WriteLine("Felicidades, acertaste.");

            }
            else{
                Console.WriteLine("Lo siento, tú resultado no es el correcto.");
            }

        }
    }
}
