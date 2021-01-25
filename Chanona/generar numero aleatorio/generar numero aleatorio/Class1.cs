using System;
using System.Collections.Generic;
using System.Text;

namespace generar_numero_aleatorio
{
    public class Class1
    {
        //participantes
       public string nombre;
        public string nombre1;
        public string nombre2;
        //numeros de rifa
       public int Nrifa;
        public int Nrifa1;
        public int Nrifa2;
        //numero aleatorio
        public int Nuga;

        public void SacoPico(string nombre,string nombre1,string nombre2, int rifa,int rifa1,int rifa2, int NuGa)
        {
            Console.WriteLine("los nombres son {0}, {1}, {2} y los numeros son {3}, {4}, {5} pero el numero ganador fue el {6}", nombre,nombre1,nombre2,rifa,rifa1,rifa2,NuGa);
        }

    }
}
