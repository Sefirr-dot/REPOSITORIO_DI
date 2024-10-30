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
            this.nombre = nombre;
            this.fuerza = fuerza;
            this.inteligencia = inteligencia;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Fuerza
        {
            get
            {
                return fuerza;
            }
            set
            {
                fuerza = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Fuerza"));
            }
        }
        public int Inteligencia
        {
            get
            {
                return inteligencia;
            }
            set
            {
                inteligencia = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Inteligencia"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
