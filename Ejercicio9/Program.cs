using System;

class Juego
{
    private static readonly Random random = new Random();
    private static readonly object synLock = new object();
    public static int random_Number(int min, int max)
    {
        lock (synLock)
        {
            return random.Next(min, max);
        }
    }
}
public class Main1
{
    private static readonly int numMin = 1;
    private static readonly int numMax = 100;
    private static readonly List<int> list = new List<int>();
    static void Main(string[] args)
    {
        
        int numeroRandom = Juego.random_Number(numMin,numMax );
        Boolean salir = false;
        int intentos = 0;
        while (!salir)
        {
            intentos++;
            Console.WriteLine($"Di un numero entre {numMin} y {numMax}");
            int numero = int.Parse(Console.ReadLine());
            list.Add(numero);
            if(numero >numeroRandom)
            {
                Console.WriteLine($"El numero es menor que {numero}");
                
                Console.WriteLine($"Llevas un total de {intentos} intentos con estos numeros:");
                foreach( int i in list)
                {
                    Console.Write("["+i+"] ");
                }
                Console.WriteLine();
            }
            else
            {
                if (numero < numeroRandom)
                {
                    Console.WriteLine($"El numero es mayor que {numero}");

                    Console.WriteLine($"Llevas un total de {intentos} intentos con estos numeros:");
                    foreach (int i in list)
                    {
                        Console.Write("[" + i + "] ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Acertaste el numero {numeroRandom} en {intentos} intentos");
                    salir = true;
                }
            }
            
        }
    }
}