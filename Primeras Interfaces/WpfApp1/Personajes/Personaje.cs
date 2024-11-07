using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personajes
{
    public class Personaje : INotifyPropertyChanged
    {
        private string nombre;
        private string genero;
        private string clase;
        private int fuerza;
        private int inteligencia;
        private int destreza;
        private int resistencia;


        public Personaje(string nombre, string clase, string genero, int fuerza, int inteligencia, int destreza, int resistencia)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.clase = clase;
            this.fuerza = fuerza;
            this.inteligencia = inteligencia;
            this.Destreza = destreza;
            this.Resistencia = resistencia;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
            }
        }
        public string Genero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Genero"));
            }
        }
        public string Clase
        {
            get
            {
                return clase;
            }
            set
            {
                clase = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Clase"));
            }
        }

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

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return Nombre+" | "+Genero+" | "+Clase + " | " +Fuerza + " | " +Inteligencia + " | " + Destreza + " | " + Resistencia;
        }
    }
}
