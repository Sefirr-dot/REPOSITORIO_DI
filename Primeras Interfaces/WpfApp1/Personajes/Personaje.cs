using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    public class Personaje
    {
        private string nombre;
        private string genero;
        private string clase;
        private int fuerza;
        private int inteligencia;
        public Personaje(string nombre, string genero, string clase, int fuerza, int inteligencia)
        {
            this.Nombre = nombre;
            this.Genero = genero;
            this.Clase = clase;
            this.Fuerza = fuerza;
            this.Inteligencia = inteligencia;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Clase { get => clase; set => clase = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Inteligencia { get => inteligencia; set => inteligencia = value; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
