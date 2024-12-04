using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Persona : IDataErrorInfo
    {
        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(Nombre):
                        if (string.IsNullOrWhiteSpace(Nombre))
                            return "El nombre no puede estar vacio";
                        break;
                    case nameof(Edad):
                        if (Edad <= 0)
                            return "La edad debe ser mayor a 0.";
                        if (Edad > 120)
                            return "La edad no puede ser mayor a 120.";
                        break;

                }
                return null;
            }
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Edad {  get; set; }

        public ICollection<Evento> EventosList { get; } = new List<Evento>();

        public string Error => null;

        //public ICollection<PersonasEventos> PersonasEventosList { get; } = new List<PersonasEventos>();

        
    }

}