using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Tienda
    {
        private List<Producto> listaProductos;
        private List<Orden> listaOrdenes;

        public Tienda(List<Producto> listaProductos, List<Orden> listaOrdenes)
        {
            this.listaProductos = listaProductos;
            this.listaOrdenes = listaOrdenes;
        }

        internal List<Producto> ListaProductos { get => listaProductos; set => listaProductos = value; }
        internal List<Orden> ListaOrdenes { get => listaOrdenes; set => listaOrdenes = value; }
    }
}
