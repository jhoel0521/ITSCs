using System;
using System.Collections.Generic;

#nullable disable

namespace ITSC.Models
{
    public partial class Consulta
    {
        public Consulta()
        {
            Verificacions = new HashSet<Verificacion>();
        }

        public int Idc { get; set; }
        public int? Ide { get; set; }
        public int? Ids { get; set; }
        public int? Idt { get; set; }
        public DateTime? Fecha { get; set; }
        public string Carta { get; set; }
        public string Estado { get; set; }

        public virtual Estudiante IdeNavigation { get; set; }
        public virtual Trabajadore IdsNavigation { get; set; }
        public virtual Tramite IdtNavigation { get; set; }
        public virtual ICollection<Verificacion> Verificacions { get; set; }
    }
}
