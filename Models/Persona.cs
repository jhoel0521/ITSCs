using System;
using System.Collections.Generic;

#nullable disable

namespace ITSC.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Estudiantes = new HashSet<Estudiante>();
            Trabajadores = new HashSet<Trabajadore>();
        }

        public int Idp { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public int? Ncell { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
        public virtual ICollection<Trabajadore> Trabajadores { get; set; }
    }
}
