using System;
using System.Collections.Generic;
using System.Text;

namespace que_pedo
{

    public class alchile
    {
        /*public int edad; // cantidad de alchiles

        public string nombre; //nombre

        public void impresion(int edad, string nombre)
        {
            Console.WriteLine("mi nombre es {0} mi edad es {1}" , nombre, edad);

        }
        */

        public int edad;

        public string nombre;

        public int boleto;

        public void impresion(string nombre, int edad, int boleto)
        {

            Console.WriteLine("mi nombre es {0} mi edad es {1} y mi boleto es {2}", nombre, edad, boleto);

            switch (boleto)
            {
                case 1:
                Console.WriteLine("felicidades, has ganado un esclavo");
                break;

                case 2:
                Console.WriteLine("felicidades, has ganado una escopeta");
                break;

                case 3:
                Console.WriteLine("felicidades, has ganado una lavadora");
                break;
            }
        }
    }


}
