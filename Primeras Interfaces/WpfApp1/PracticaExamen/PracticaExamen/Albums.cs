using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen
{
    public class Albums
    {
        public Albums(string titulo, string image, string subtitulo)
        {
            this.Titulo = titulo;
            this.Image = image;
            this.Subtitulo = subtitulo;
        }

        public string Titulo { get; set; }
        public string Image { get; set; }
        public string Subtitulo { get; set; }
    }
}
