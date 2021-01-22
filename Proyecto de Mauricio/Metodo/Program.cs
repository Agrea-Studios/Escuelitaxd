using System;

namespace Metodo
{
    class Program
    {
        static Decimal rf(){
            Double pi = 3.1416;
            Double r;
            Double r1;
            Double rf1;
            Decimal p;
            Console.WriteLine("Introduzca un radio para que el área del círculo sea 78.54:");
            r = Convert.ToDouble(Console.ReadLine());
            r1= r*r;
            rf1= r1*pi;
            p = Convert.ToDecimal(rf1);
            p = Decimal.Round(p, 2);
            return p;


        }
        static void Main(string[] args)
        {
            string cl;
            
            cl = (rf() == 78.54M) ? "Felicidades, es correcto." : "Lo siento, estás mal.";
            Console.WriteLine(cl);

        }
        
    }
}    
