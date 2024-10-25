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
        private ObservableCollection<Objeto> objetoList;

        public Personaje(string nombre, string genero, string clase, int fuerza, int inteligencia, ObservableCollection<Objeto> objetoList)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.clase = clase;
            this.fuerza = fuerza;
            this.inteligencia = inteligencia;
            this.ObjetoList = objetoList;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Clase { get => clase; set => clase = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Inteligencia { get => inteligencia; set => inteligencia = value; }
        public ObservableCollection<Objeto> ObjetoList { get => objetoList; set => objetoList = value; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return Nombre+" | "+Genero+" | "+Clase + " | " +Fuerza + " | " +Inteligencia;
        }
    }
}
