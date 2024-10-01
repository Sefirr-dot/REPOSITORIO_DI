using System.Collections;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args) { 
        ArrayList lista = new ArrayList();
        lista.Add(1);
        lista.Add("hola");

        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
        lista.Remove(2);
        foreach (int item in lista)
        {
            Console.WriteLine(item);
        }
}
}