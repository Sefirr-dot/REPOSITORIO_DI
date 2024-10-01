using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio12
{
    internal class ProductoElec : Producto
    {
        private DateTime garantia;

        public ProductoElec(DateTime garantia,string nombre, double precio, int cantidad) : base( nombre,  precio,  cantidad)
        {
            this.garantia = garantia;
        }

        public DateTime Garantia { get => garantia; set => garantia = value; }

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Garantia: {garantia}");
        }
    }
}
