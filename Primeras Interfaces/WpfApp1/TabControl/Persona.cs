using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid
{
    public class Persona
    {
        private string nombre;
        private string apellidos;
        private int edad;

        public Persona(string nombre, string apellidos, int edad)
        {
            this.Nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }
        public int Edad { get => edad; set => edad = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
