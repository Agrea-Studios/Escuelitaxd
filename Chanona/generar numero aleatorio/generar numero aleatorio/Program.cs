using System;

namespace generar_numero_aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 usuarios = new Class1();
            
            Console.WriteLine("ingrese el nombre de los participantes");
            
            usuarios.nombre = Console.ReadLine();
            usuarios.nombre1 = Console.ReadLine();
            usuarios.nombre2 = Console.ReadLine();

            Console.WriteLine("ingrese su numero de rifa");

            usuarios.Nrifa = Convert.ToInt32(Console.ReadLine());
            usuarios.Nrifa1 = Convert.ToInt32(Console.ReadLine());
            usuarios.Nrifa2 = Convert.ToInt32(Console.ReadLine());

            //generando el numero ganador de la rifa
            //Console.WriteLine("y el ganador de la rifa es:");
            Random NuGa = new Random();
            usuarios.Nuga = NuGa.Next(1,4);

            //la rifa asies:
            switch(usuarios.Nuga)
            {
                case 1: Console.WriteLine("Felicidades, perdiste dinero a lo pendejo porque perdiste la rifa");
                    break;
                case 2: Console.WriteLine("Felicidades, has ganado");
                    break;
                case 3: Console.WriteLine("Ni modo chavo, no ganaste");
                    break;
                default: Console.WriteLine("Gano la juez");
                    break;
            }

            usuarios.SacoPico(nombre: usuarios.nombre,nombre1:usuarios.nombre1,nombre2:usuarios.nombre2, rifa: usuarios.Nrifa,rifa1:usuarios.Nrifa1,rifa2:usuarios.Nrifa2, NuGa: usuarios.Nuga);

            
        }
    }
}
