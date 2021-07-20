using System;
using System.Collections.Generic;

#nullable disable

namespace ITSC.Models
{
    public partial class Carrera
    {
        public Carrera()
        {
            Estudiantes = new HashSet<Estudiante>();
        }

        public int Idc { get; set; }
        public string NombreC { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}
