using System;

class Program
{
    static void Main(String[] args)
    {
        int numero;
        Console.WriteLine("Di un numero");
        numero= int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("Par");
        } else
        {
            Console.WriteLine("Impar");
        }
    }
}
