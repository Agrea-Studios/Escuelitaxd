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
            Double r2,rf2,x=5,r3,rf3,x2=6,r4,rf4,x3=7;
            r2 = x * x;
            rf2 = r2 * pi; 
            r1 = r * r;
            rf = r1 * pi;
            r3 = x2 * x2;
            rf3 = r3 * pi;
            r4 = x3 * x3;
            rf4 = r4 * pi;
            decimal p,p2,p3,p4;
            p2 = Convert.ToDecimal(rf2);
            p2 = Decimal.Round(p2, 2);
            p3 = Convert.ToDecimal(rf3);
            p3 = Decimal.Round(p3, 2);
            p = Convert.ToDecimal(rf);
            p = Decimal.Round(p, 2);
            p4 = Convert.ToDecimal(rf4);
            p4 = Decimal.Round(p4, 2);
        switch(p){

         case 78.54M:
         Console.WriteLine("Felicidades, acertaste.");
         break;
         case 153.94M:
         Console.WriteLine("Tu resultado es incorrecto:"+ p4);
         break;
         case 113.10M:
         Console.WriteLine("Tu resultado está mal:"+ p3);
         break;
         default:
         Console.WriteLine("Lo siento, es incorrecto, tu resultado es:"+ p);
         break;

        }
        }
    }
}
