using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIKeys
{
    internal class resultadoBusqueda
    {
        [JsonProperty("Search")]

        public List<Pelicula> Peliculas { get; set; 
    }
}
