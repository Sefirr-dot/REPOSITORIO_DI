using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        Console.WriteLine("Di un numero");
        numero = int.Parse(Console.ReadLine());
        int suma = 0;
        for (int i = 1; i <= numero; i++)
        {
            suma += i;
        }
        Console.WriteLine("La suma del numero " + numero + " es: " + suma);
        double media = (double) suma / numero;
        Console.WriteLine("La media es: " + media);
    }
}
