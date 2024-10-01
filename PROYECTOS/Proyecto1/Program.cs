class Proyecto1
{
    static void Main(string[] args)
    {

        Boolean salir = false;

        int[,] rio = rioGuadalquivir();
        char[,] rioCubierto = rioEncubierto();
        int contador = 0;
        int[] intentos = { 20 };

        while (!salir)
        {

            Console.WriteLine("Di una tecla w, a, s, d");
            char letra = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Clear();
            contador = contadorPuntos(juegoDescubrir(rio, rioCubierto, letra, contador, intentos), contador);

            Console.WriteLine("Levas: " + contador + " peces");
            Console.WriteLine("Te quedan: " + intentos[0] + " intentos");

            if (isCompleto(rio, rioCubierto))
            {
                rio = rioGuadalquivir();
                rioCubierto = rioEncubierto();
            }

            else if (isWon(contador))
            {
                salir = true;
                Console.WriteLine("Adios");
            }
            else if (isLost(intentos[0]))
            {
                salir = true;
                Console.WriteLine("Has perdido Adios");
            }

        }




    }
    public static Boolean isLost(int intentos)
    {
        Boolean ganado = false;
        if (intentos == 0)
        {
            ganado = true;
        }
        return ganado;
    }
    public static Boolean isWon(int contador)
    {
        Boolean ganado = false;
        if (contador == 10)
        {
            ganado = true;
        }
        return ganado;
    }
    public static Boolean isCompleto(int[,] tablero, char[,] rio)
    {
        int multiplicacion = tablero.GetLength(0) * tablero.GetLength(1) * 17;
        int sumaTotal = 0;
        Boolean rehacer = false;
        for (int i = 0; i < tablero.GetLength(0); i++)
        {

            for (int j = 0; j < tablero.GetLength(1); j++)
            {
                sumaTotal += tablero[i, j];
            }
        }
        if (sumaTotal == multiplicacion)
        {
            rehacer = true;
        }
        return rehacer;
    }
    public static int contadorPuntos(char spot, int contador)
    {

        if (spot == 's')
        {
            contador++;
        }
        else if (spot == 'c')
        {
            contador = 0;
        }
        return contador;
    }
    public static int[,] rioGuadalquivir()
    {
        Random rnd = new Random();
        int[,] guadalquivir = new int[5, 5];
        for (int i = 0; i < guadalquivir.GetLength(0); i++)
        {

            for (int j = 0; j < guadalquivir.GetLength(1); j++)
            {
                int pececito = rnd.Next(20) + 1;
                guadalquivir[i, j] = pececito;
            }
        }
        guadalquivir[0, 0] = 17;
        return guadalquivir;
    }
    public static char[,] rioEncubierto()
    {
        char[,] guadalquivir = new char[5, 5];
        for (int i = 0; i < guadalquivir.GetLength(0); i++)
        {

            for (int j = 0; j < guadalquivir.GetLength(1); j++)
            {

                guadalquivir[i, j] = '*';
            }
        }
        guadalquivir[0, 0] = 'O';
        return guadalquivir;
    }
    public static char juegoDescubrir(int[,] tablero, char[,] tableroEscondido, char letra, int contador, int[] intentos)
    {
        int posi = 0;
        int posj = 0;
        intentos[0] -= 1;
        Boolean salir = false;
        char suma = 'n';

        for (int i = 0; i < tablero.GetLength(0); i++)
        {

            for (int j = 0; j < tablero.GetLength(1); j++)
            {
                if (tableroEscondido[i, j] == 'O' && !salir)
                {
                    if (tablero[i, j] % 2 == 0 && tablero[i, j] != 20)
                    {
                        moverConLetra(letra, tableroEscondido);
                        tableroEscondido[i, j] = 'P';
                        salir = true;
                        suma = 's';
                        Console.WriteLine("Has pescado un Pez!!");
                        tablero[i, j] = 17;
                    }
                    else if (tablero[i, j] % 2 == 1 && tablero[i, j] % 5 != 0 && tablero[i, j] != 20)
                    {
                        moverConLetra(letra, tableroEscondido);
                        tablero[i, j] = 17;
                        tableroEscondido[i, j] = 'A';
                        salir = true;
                        suma = 'z';
                        Console.WriteLine("AGUAA");
                    }
                    else if (tablero[i, j] == 20)
                    {
                        moverConLetra(letra, tableroEscondido);
                        tablero[i, j] = 17;
                        tableroEscondido[i, j] = 'N';
                        salir = true;
                        suma = 'c';
                        Console.WriteLine("Piraña!!!!!");
                    }
                    else
                    {
                        tablero[i, j] = 17;
                        moverConLetra(letra, tableroEscondido);
                        tableroEscondido[i, j] = 'R';
                        salir = true;
                        suma = 'z';
                        Console.WriteLine("Manzana!");
                        intentos[0] += 5;
                    }
                }

            }
        }
        dibujarTabla(tableroEscondido);
        Console.WriteLine();

        return suma;
    }
    public static void moverConLetra(char letra, char[,] a)
    {
        int posi = 0;
        int posj = 0;


        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] == 'O')
                {
                    if (j - 1 > -1 && letra == 'a')
                    {
                        posi = i;
                        posj = j - 1;
                    }
                    else if (i + 1 < a.GetLength(1) && letra == 's')
                    {
                        posi = i + 1;
                        posj = j;
                    }
                    else if (j + 1 < a.GetLength(0) && letra == 'd')
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

            }

        }

        a[posi, posj] = 'O';

    }
    public static void dibujarTabla(char[,] a)
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
    public static void dibujarTabla(int[,] a)
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



}
