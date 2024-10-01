using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio12
{
    internal class ProductoAlimenticio : Producto
    {
        private DateTime fechaCaducidad;

        public ProductoAlimenticio(DateTime fechaCaducidad, string nombre, double precio, int cantidad) : base(nombre, precio, cantidad)
        {
            this.fechaCaducidad = fechaCaducidad;
        }
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Fecha caducidad: {fechaCaducidad}");
        }
    }
    }
}
