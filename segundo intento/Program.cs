using System;

namespace segundo_intento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe el radio requerido para que el area de un circulo sea 78.54");

            double radio;

            radio = Convert.ToDouble(Console.ReadLine());

            double pi = 3.1416;
            double radio1;
            double radiof;

            double radio2, radiof2, x = 5;

            radio2 = x * x;
            radiof2 = radio2 * pi;
            radio1 = radio * radio;
            radiof = radio1 * pi;
            
            if (radiof == radiof2) {
                Console.WriteLine("felicidades el area si es 78.54");
            }
            else {
                Console.WriteLine("lo siento el area no es 78.54");
                 }

           
        }
    }
}
