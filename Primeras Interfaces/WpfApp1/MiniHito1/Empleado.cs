using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHito1
{
    public class Empleado
    {
        private int id;
        private string nombre;
        private string rol;
        private double coste_por_hora;

        public Empleado(int id, string nombre, string rol, double coste_por_hora)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Rol = rol;
            this.Coste_por_hora = coste_por_hora;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Rol { get => rol; set => rol = value; }
        public double Coste_por_hora { get => coste_por_hora; set => coste_por_hora = value; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
