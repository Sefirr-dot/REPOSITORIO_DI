    using System;

    class Proyecto11
    {
        static void Main(string[] args)
        {
            int posX = 0, posY = 0;  // Posición inicial de Pinocho
            int[,] rio = generarNuevoRio();  // Inicializamos el primer río
            char[,] rioCubierto = inicializarRioCubierto(posX, posY);  // Inicializamos el tablero cubierto
            int pecesContador = 0;  // Contador de peces
            int energia = 20;  // Energía inicial
            bool juegoTerminado = false;

            while (!juegoTerminado)
            {
                // Mostrar el estado actual del río
                dibujarTabla(rioCubierto);

                // Movimiento del jugador
                Console.WriteLine("Movimiento (w: arriba, s: abajo, a: izquierda, d: derecha):");
                char movimiento = Console.ReadKey().KeyChar;
                Console.Clear();

                var resultadoMovimiento = moverPinocho(movimiento, posX, posY, rio.GetLength(0), rio.GetLength(1));
                int nuevoX = resultadoMovimiento.Item1;
                int nuevoY = resultadoMovimiento.Item2;
                bool fueraDelMapa = resultadoMovimiento.Item3;

                if (fueraDelMapa)
                {
                    // Reposicionar Pinocho en el borde opuesto y generar un nuevo río
                    rio = generarNuevoRio();

                    // Reposicionar correctamente al salir del mapa
                    if (nuevoX < 0)
                    {
                        nuevoX = rio.GetLength(0) - 1;  // Si sale por arriba, aparece abajo
                    }
                    else if (nuevoX >= rio.GetLength(0))
                    {
                        nuevoX = 0;  // Si sale por abajo, aparece arriba
                    }

                    if (nuevoY < 0)
                    {
                        nuevoY = rio.GetLength(1) - 1;  // Si sale por la izquierda, aparece a la derecha
                    }
                    else if (nuevoY >= rio.GetLength(1))
                    {
                        nuevoY = 0;  // Si sale por la derecha, aparece a la izquierda
                    }

                    rioCubierto = inicializarRioCubierto(nuevoX, nuevoY);  // Reposicionamos a Pinocho en el nuevo río
                    posX = nuevoX;
                    posY = nuevoY;

                    Console.WriteLine("¡Nuevo río generado!");
                }
                else
                {
                    // Verificar si Pinocho sigue dentro del mapa
                    if (nuevoX >= 0 && nuevoX < rio.GetLength(0) && nuevoY >= 0 && nuevoY < rio.GetLength(1))
                    {
                        // Mover Pinocho dentro del mapa
                        rioCubierto[posX, posY] = '*';  // Marcar la posición anterior
                        rioCubierto[nuevoX, nuevoY] = 'O';  // Nueva posición de Pinocho
                        posX = nuevoX;
                        posY = nuevoY;

                        // Revisar el contenido de la nueva posición
                        if (rio[posX, posY] == -1)  // Casilla ya visitada (pez capturado o piraña encontrada)
                        {
                            Console.WriteLine("Ya has visitado esta casilla.");
                        }
                        else if (rio[posX, posY] % 2 == 0)  // Pez
                        {
                            pecesContador++;
                            Console.WriteLine("¡Has pescado un pez!");
                            rio[posX, posY] = -1;  // Marcar la casilla como visitada
                        }
                        else if (rio[posX, posY] % 5 == 0)  // Piraña
                        {
                            pecesContador = 0;
                            Console.WriteLine("¡Piraña! Has perdido todos los peces.");
                            rio[posX, posY] = -1;  // Marcar la casilla como visitada
                        }
                        else if (rio[posX, posY] == 20)  // Manzana
                        {
                            energia += 5;
                            Console.WriteLine("¡Manzana! Has recuperado energía.");
                            rio[posX, posY] = -1;  // Marcar la casilla como visitada
                        }
                    }

                    // Verificar el estado del juego
                    energia--;
                    if (energia <= 0)
                    {
                        juegoTerminado = true;
                        Console.WriteLine("Te has quedado sin energía. Fin del juego.");
                    }
                    else if (pecesContador >= 10)
                    {
                        juegoTerminado = true;
                        Console.WriteLine("¡Felicidades! Has ganado la competencia con 10 peces.");
                    }
                }

                Console.WriteLine($"Peces: {pecesContador}, Energía: {energia}");
            }
        }

        // Método para mover a Pinocho dentro y fuera del mapa
        public static Tuple<int, int, bool> moverPinocho(char direccion, int x, int y, int maxX, int maxY)
        {
            int nuevoX = x;
            int nuevoY = y;
            bool salirDelMapa = false;

            // Movimiento según la dirección
            if (direccion == 'w') nuevoX--;  // Arriba
            else if (direccion == 's') nuevoX++;  // Abajo
            else if (direccion == 'a') nuevoY--;  // Izquierda
            else if (direccion == 'd') nuevoY++;  // Derecha

            // Verificar si Pinocho sale del mapa
            if (nuevoX < 0 || nuevoX >= maxX || nuevoY < 0 || nuevoY >= maxY)
            {
                salirDelMapa = true;
            }

            return Tuple.Create(nuevoX, nuevoY, salirDelMapa);
        }

        // Genera un nuevo río con elementos aleatorios
        public static int[,] generarNuevoRio()
        {
            Random rnd = new Random();
            int[,] nuevoRio = new int[5, 5];
            for (int i = 0; i < nuevoRio.GetLength(0); i++)
            {
                for (int j = 0; j < nuevoRio.GetLength(1); j++)
                {
                    int elemento = rnd.Next(20) + 1;
                    nuevoRio[i, j] = elemento;
                }
            }
            return nuevoRio;
        }

        // Inicializa el tablero cubierto con Pinocho en la posición inicial
        public static char[,] inicializarRioCubierto(int x, int y)
        {
            char[,] rioCubierto = new char[5, 5];
            for (int i = 0; i < rioCubierto.GetLength(0); i++)
            {
                for (int j = 0; j < rioCubierto.GetLength(1); j++)
                {
                    rioCubierto[i, j] = '*';
                }
            }
            rioCubierto[x, y] = 'O';  // Posiciona a Pinocho en el nuevo río
            return rioCubierto;
        }

        // Dibuja el tablero cubierto para mostrarlo en pantalla
        public static void dibujarTabla(char[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
