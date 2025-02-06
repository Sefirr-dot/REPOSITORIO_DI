using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIKeys
{
    public class Pelicula
    {
        private string titulo;
        private int anio;
        private string poster;

        public Pelicula(string titulo, int anio, string poster)
        {
            this.Titulo = titulo;
            this.Anio = anio;
            this.Poster = poster;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Anio { get => anio; set => anio = value; }
        public string Poster { get => poster; set => poster = value; }
    }
}
