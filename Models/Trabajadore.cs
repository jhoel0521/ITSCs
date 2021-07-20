using System;
using System.Collections.Generic;

#nullable disable

namespace ITSC.Models
{
    public partial class Trabajadore
    {
        public Trabajadore()
        {
            Consulta = new HashSet<Consulta>();
            VerificacionDa = new HashSet<VerificacionDum>();
            Verificacions = new HashSet<Verificacion>();
        }

        public int Idt { get; set; }
        public int? Idp { get; set; }
        public int? Idr { get; set; }
        public string Usuario { get; set; }
        public string Contra { get; set; }

        public virtual Persona IdpNavigation { get; set; }
        public virtual Role IdrNavigation { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
        public virtual ICollection<VerificacionDum> VerificacionDa { get; set; }
        public virtual ICollection<Verificacion> Verificacions { get; set; }
    }
}
