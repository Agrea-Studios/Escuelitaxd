using System;

namespace que_pedo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");

            Random x = new Random();

            int numero;

            numero = x.Next(1, 11);
            Console.WriteLine(numero);

            alchile persona = new alchile();

            persona.edad = 22;
            persona.nombre = "manuel";
            
            persona.impresion(persona.edad, persona.nombre);
            */

            alchile persona1 = new alchile();

            Console.WriteLine("ingrese un nombre");

            persona1.nombre = Console.ReadLine();

            Console.WriteLine("ingrese su edad");

            persona1.edad = Convert.ToInt32(Console.ReadLine());

            Random numeroA = new Random();
            int boleto;
            boleto = numeroA.Next(1, 4);
            Console.WriteLine(boleto);

            persona1.impresion(nombre: persona1.nombre, edad: persona1.edad, boleto);

        }
    }
}
