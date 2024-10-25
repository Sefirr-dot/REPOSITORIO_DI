using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    public class Objeto : INotifyPropertyChanged
    {
        private string nombre;
        private int fuerza;
        private int inteligencia;

        public Objeto(string nombre, int fuerza, int inteligencia)
        {
            this.Nombre = nombre;
            this.Fuerza = fuerza;
            this.Inteligencia = inteligencia;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Inteligencia { get => inteligencia; set => inteligencia = value; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
