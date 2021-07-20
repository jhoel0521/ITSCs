using System;
using System.Collections.Generic;

#nullable disable

namespace ITSC.Models
{
    public partial class Estudiante
    {
        public Estudiante()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdE { get; set; }
        public int? Idp { get; set; }
        public int? Idc { get; set; }

        public virtual Carrera IdcNavigation { get; set; }
        public virtual Persona IdpNavigation { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
