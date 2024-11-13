using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHito1
{
    public class Proyecto
    {
        private int id;
        private string nombre;
        private double presupuesto_inicial;

        public Proyecto(int id, string nombre, double presupuesto_inicial)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Presupuesto_inicial = presupuesto_inicial;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Presupuesto_inicial { get => presupuesto_inicial; set => presupuesto_inicial = value; }
    }
}
