using System;

class Program()
{
    static void Main(string[] args)
    {
        int[,] hola = new int[4, 4];

        int[,] hola1 = new int[4, 4];
        int suma = 0;
        for (int i = 0; i < hola.GetLength(0); i++)
        {
            for (int j = 0; j < hola.GetLength(1); j++)
            {
                suma += hola[i,j] + hola[i,j];
            }

        }
        Console.WriteLine(suma);


        Random r1 = new Random();
        int numero = r1.Next(100);
        Console.WriteLine(numero);
        int[,] hello = new int[20,20];

        for (int i = 0; i < hello.GetLength(0); i++)
        {
            for (int j = 0; j < hello.GetLength(1); j++)
            {
                if (j == i)
                {
                    hello[i,j] = i;
                }
            }

        }
        for (int i = 0; i < hello.GetLength(0); i++)
        {
            for (int j = 0; j < hello.GetLength(1); j++)
            {
                Console.Write(hello[i,j] + " ");
            }
            Console.WriteLine();
        }

    
}
}