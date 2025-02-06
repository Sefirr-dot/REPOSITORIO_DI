using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConjunto.models
{
    class PasosReceta
    {

        private int id;
        private int numPaso;
        private string descripcion;
        private int idReceta;

        public PasosReceta(int id, int numPaso, string descripcion, int idReceta)
        {
            this.id = id;
            this.numPaso = numPaso;
            this.descripcion = descripcion;
            this.idReceta = idReceta;
        }

        public int Id { get => id; set => id = value; }
        public int NumPaso { get => numPaso; set => numPaso = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdReceta { get => idReceta; set => idReceta = value; }
    }

}
