using System;

namespace ConsoleApp1
{
    class Program
    {
        static void metoculo (int x)
        {
            decimal pi = 3.14m;
            decimal resultado = x * pi;
            resultado = resultado * resultado; 
            Console.WriteLine(resultado); 
        }
        static void Main(string[] args)
        {
            int pilin; 
            metodote(pilin = Convert.Toint32(Console.ReadLine()));
        }