using System;

class Program
{
    static void Main(string[] args)
    {
        double total = 0;
        int contador = 2;
        int pi = 100000000;
        for (int i = 1; i <= pi; i+=2)
        {
           
            if (contador % 2 == 0)
            {
                total += (1.0 / i) ;
            }
            else
            {
                total -= (1.0 / i) ;
            }
            contador++;
            }
        double total1 = 0.0;
        for (int i = 0; i < pi; i++) {
            double termino = Math.Pow(-1, i) / (2.0 * i + 1);
            total1 += termino ; 
        }

        Console.WriteLine(total * 4.0);
        Console.WriteLine(total1 *4.0);
    }
}