using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Orden
    {
        private Cliente cliente;
        private List<Producto> listaProductos;
        private double total;

        public Orden(Cliente cliente, List<Producto> listaProductos, double total)
        {
            this.cliente = cliente;
            this.listaProductos = listaProductos;
            this.total = total;
        }

        public double Total { get => total; set => total = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal List<Producto> ListaProductos { get => listaProductos; set => listaProductos = value; }
    }
}
