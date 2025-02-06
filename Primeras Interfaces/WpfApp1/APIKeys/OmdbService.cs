using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIKeys
{
    internal class OmdbService
    {
        private const string APIKey = "56112458";

        public async Task<Pelicula> BuscarPeliculaAsync(string titulo)
        {
            using (var cliente = new HttpClient())
            {
                String url= $"http://www.omdbapi.com/?apikey={APIKey}&t={titulo}";

                var respuesta = await cliente.GetAsync(url);
                var jsonRespuesta = JsonConvert.DeserializeObject<resultadoBusqueda>(respuesta);

                if(jsonRespuesta)
            }
    }
}
