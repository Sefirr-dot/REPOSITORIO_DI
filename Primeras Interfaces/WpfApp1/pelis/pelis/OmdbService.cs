using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace pelis
{
    internal class OmdbService
    {
        private const string ApiKey = "56112458";
        public async Task<Personaje> ObtenerPeliculasAsync(string titulo)
        {
            using (var cliente = new HttpClient())
            {
                String url = $"https://dragonball-api.com/api/characters/{Uri.EscapeDataString(titulo)}";

                var respuesta = await cliente.GetStringAsync(url);
                Personaje jsonRespuesta = JsonConvert.DeserializeObject<Personaje>(respuesta);

                if (jsonRespuesta != null)
                {
                    return jsonRespuesta;
                }
                else
                {
                    return null;
                }
            }
        }

    }
}