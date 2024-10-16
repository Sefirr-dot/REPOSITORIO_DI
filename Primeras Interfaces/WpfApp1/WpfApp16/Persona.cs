using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp16
{
    internal class Persona
    {
        public string Profesion { get; set; }
        public int NumeroHermanos { get; set; }
        public string Sexo { get; set; }
        public string Edad { get; set; }
        public string DeportesQuePractica { get; set; }
        public int Compras { get; set; }
        public int Tele { get; set; }
        public int Cine { get; set; }

        public Persona(string profesion, int numeroHermanos, string sexo, string edad, string deportesQuePractica, int compras, int tele, int cine)
        {
            Profesion = profesion;
            NumeroHermanos = numeroHermanos;
            Sexo = sexo;
            Edad = edad;
            DeportesQuePractica = deportesQuePractica;
            Compras = compras;
            Tele = tele;
            Cine = cine;
        }




    }
}
