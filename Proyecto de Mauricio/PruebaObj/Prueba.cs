using System;

public class bertold{
    public int GenA(){
    Random f = new Random();
    int x;
    x = f.Next(1, 4);
    return x;
    }
    public int numerox;
    public string nombre1,nombre2,nombre3;
    public void imprimir(string nombre){
        Console.WriteLine("Felicidades, el ganador es: {0}", nombre);
    }
    
}


