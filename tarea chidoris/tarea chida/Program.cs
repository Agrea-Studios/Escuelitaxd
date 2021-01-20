using System;

namespace tarea_chida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double apotema = 5.2;

            int lado = 6;

            int perimetro;

            double area;

            perimetro = lado + lado + lado + lado + lado + lado;



            area = perimetro * apotema / 2;

            Console.WriteLine("el resultado es");
            Console.WriteLine(area);

        }
    }
}
