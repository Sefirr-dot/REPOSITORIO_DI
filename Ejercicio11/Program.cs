using System;
using System.Diagnostics;
class Tablero
{
    static void Main(string[] args)
    {
        String[,] a = new String[10, 10];

       
        crearTabla(a);
        
        Boolean salir = false;

        while (!salir)
        {
            
            Console.WriteLine("Di una tecla w, a, s, d");
            char hola = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Clear();
            moverConLetra(hola, a);
            
            
            if( hola == '0')
            {
                salir = true;
                Console.WriteLine("ADios");
            }

        }

    }
    public static void crearTabla(String[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                a[i, j] = "x";
                
            }
            
        }
        a[0, 0] = "O";
    }
    public static void dibujarTabla(String[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {

                Console.Write(a[i, j]);
            }
            Console.WriteLine();
        }
    }


    public static void moverConLetra(char letra, String[,] a)
    {
        int posi = 0;
        int posj = 0;


        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] == "O")
                {
                    if (i - 1 > -1 && letra == 'a')
                    {
                        posi = i;
                        posj = j-1;
                    }
                    else if (j + 1 < a.GetLength(0) && letra == 's')
                    {
                        posi = i+1;
                        posj = j;
                    }
                    else if (j + 1 < a.GetLength(1) && letra == 'd')
                    {
                        posi = i;
                        posj = j + 1;
                    }
                    else if (i - 1 > -1 && letra == 'w')
                    {
                        posi = i - 1;
                        posj = j;
                    }

                }
                a[i, j] = "x";
            }

        }

        a[posi, posj] = "O";
        dibujarTabla(a);
    }

}