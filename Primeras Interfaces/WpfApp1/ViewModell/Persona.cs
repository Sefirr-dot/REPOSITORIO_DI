using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModell
{
    public class Persona
    {
        private string nombre;
        private int edad;
        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public string Nombre { get; set; }
        public int Edad { get; set; }

    }
}
