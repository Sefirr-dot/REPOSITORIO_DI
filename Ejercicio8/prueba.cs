using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ejercicio8
{
    internal class prueba
    {
        static void Main(string[] args)
        {
            List<Dia> list = new List<Dia>();

            list.Add(new Dia("Lunes", 25));
            list.Add(new Dia("Martes", 26));
            list.Add(new Dia("Miercoles", 27));
            list.Add(new Dia("Jueves", 28));
            list.Add(new Dia("Viernes", 29));

            foreach (Dia dia in list)
            {
                Console.WriteLine(dia.ToString);
            }
        }
    }
}
