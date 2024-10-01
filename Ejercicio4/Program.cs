using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Di el numero de la vvariable");
        int numero = int.Parse(Console.ReadLine());
        double total = 0;
        for (int i = 1; i <= numero; i++)
        {
            total += (1.0 / i);
        }
        double total1 = 0;
        for (int i = numero; i >= 1; i--)
        {
            total1 += (1.0 / i);
        }


        Console.WriteLine(total);
        Console.WriteLine(total1);
    }
}