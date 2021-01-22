using System;

namespace Switch_y_metodos
{
    class Program
    {
        //Clase de Metodos
        /* static void Circulo(decimal x)
        {
            decimal pi = 3.1416m;
            x = pi * x * x;
            x = decimal.Round(x, 2);
            if(x == 78.54m)
            {
                Console.WriteLine("Felicidades es correcto");
            }

            else
            {
                Console.WriteLine("Andate con tu noviecita durito");
            }
        }

        static void Main(string[] args)
        {
            Circulo(Convert.ToDecimal(Console.ReadLine()));
        } */

        //Clase de switch
        static void Main()
        {
            Console.WriteLine("ingresa el valor del radio para que el area de un circulo sea 94.10 o 153.94,113.10");
            double radio = Convert.ToDouble(Console.ReadLine());
            switch (radio)
            {
                case 5: Console.WriteLine("como tu radio es 5, tu área es: 94.10"); break;
                case 6: Console.WriteLine("como tu radio es 6, tu área es: 153.94"); break;
                case 7: Console.WriteLine("como tu radio es 7, tu área es: 113.10"); break;
                default: Console.WriteLine("estas tonto? eso no da el area de las opciones"); break;
            }
        }
    }
}
