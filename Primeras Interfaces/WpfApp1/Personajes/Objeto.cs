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
        private int id;
        private string nombre;
        private string tipo;
        private int fuerza;
        private int inteligencia;
        private int destreza;
        private int resistencia;


        public Objeto(int id, string nombre, string tipo,int fuerza, int inteligencia,int desreza,int resistencia)
        {
            this.id = id;
            this.nombre = nombre;
            this.Tipo = tipo;
            this.fuerza = fuerza;
            this.inteligencia = inteligencia;
            this.Destreza = desreza;
            this.Resistencia = resistencia;
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

        public int Destreza { get => destreza; set => destreza = value; }
        public int Resistencia { get => resistencia; set => resistencia = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return nombre + " | " + tipo + " | " + fuerza + " | " + inteligencia + " | " + destreza + " | " + resistencia;
        }
    }
}
