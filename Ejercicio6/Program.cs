using System;

class Program
{
    static void Main(string[] args)
    {
        for(int i =1; i <= 9; i++)
        {
            Console.Write($"{i,4}");
        }
        Console.WriteLine();
        Console.WriteLine("------------------------------------------");

        for (int i = 1; i <=9; i++)
        {
            Console.Write(i+" |");
            for (int j = 1; j <= 9; j++)
            {
                Console.Write($"{i*j,4}");
            }
            Console.WriteLine();
        }

    }
}