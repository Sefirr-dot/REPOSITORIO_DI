// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[,] matriz = new int[4,4];
int[,] matriz1 =
{
    {1,2,3 },
    {2,0, 123 }
};

int numeroMayor = 0;
int numeroMenor = 100;
string posMayor = "";
string posMenor = "";

for(int i = 0; i< matriz1.GetLength(0); i++)
{
    for(int j = 0; j < matriz1.GetLength(1); j++)
    {
        if (numeroMayor < matriz1[i, j])
        {
            numeroMayor=matriz1[i, j];
            posMayor = $"Cordenada i: {i} Cordenada j: {j}";
        }
        if(numeroMenor> matriz1[i, j])
        {
            numeroMenor = matriz1[i, j];
            posMenor = "Cordenada i: " +i+ " Cordenada j: "+j;
            
        }
    }
}
Console.WriteLine($"El numero mayor es: {numeroMayor} y esta en la {posMayor}. ");
Console.WriteLine($"El menor es: {numeroMenor} y esta en la {posMenor}");


int[,] matriz2 =
{
    {1,2,3 },
    {4,2, 3 },
    {7,1, 3 }
};
int[,] matriz3 =
{
    {1,2,3 },
    {4,2, 3 },
    {7,1, 3 }
};
int[,] matrizAux = new int[3,3];
Boolean salir = false;
int contador = 0;

for (int i = 0; i < matriz2.GetLength(0); i++)
{
    
    for(int j = 0;j< matriz2.GetLength(1); j++)
    {
        for (int k = 0;k< matriz2.GetLength(0); k++)
        {
            matrizAux[i, j] += matriz2[i,k] * matriz3[k,j];
        }  
    }
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("La multiplicacion de las dos matrices es: ");
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < matrizAux.GetLength(0); i++)
{
    for(int j = 0; j< matrizAux.GetLength(1); j++)
    {
        Console.Write(matrizAux[i, j]+" ");
    }
    Console.WriteLine();
}