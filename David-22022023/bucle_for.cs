using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("ingrese un valor inicial: ");
        int inicio = Convert.ToInt32(Console.ReadLine());

        Console.Write("ingrese un valor final: ");
        int fin = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("los números pares entre {0} y {1} son:", inicio, fin);
        for (int i = inicio; i <= fin; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}