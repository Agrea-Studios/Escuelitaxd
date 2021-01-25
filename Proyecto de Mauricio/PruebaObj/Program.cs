using System;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
           bertold xd = new bertold();
           xd.numerox = xd.GenA();
           Console.WriteLine("Ingrese el primer nombre:");
           xd.nombre1 = Console.ReadLine();
           Console.WriteLine("Ingrese el segundo nombre:");
           xd.nombre2 = Console.ReadLine();
           Console.WriteLine("Ingrese el tercer nombre:");
           xd.nombre3 = Console.ReadLine();
           switch (xd.numerox)
           {
               case 1:
               xd.imprimir(nombre: xd.nombre1);
               break;
               case 2:
               xd.imprimir(nombre: xd.nombre2);
               break;
               case 3:
               xd.imprimir(nombre: xd.nombre3);
               break;
           }

           

    }


        }
    }
