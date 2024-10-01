using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Producto
    {
        private string nombre;
        private double precio;
        private int cantidad;

        public Producto(string nombre, double precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Caantidad { get => cantidad; set => cantidad = value; }
       
        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {nombre} Precio:{precio} Cantidad:{cantidad}");
        }
    }

    
}
