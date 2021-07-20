using System;
using System.Collections.Generic;

#nullable disable

namespace ITSC.Models
{
    public partial class VerificacionDum
    {
        public int Idvda { get; set; }
        public int? Idv { get; set; }
        public int? Idt { get; set; }
        public DateTime? Fechafirma { get; set; }
        public string CartaRespuesta { get; set; }
        public string Estado { get; set; }

        public virtual Trabajadore IdtNavigation { get; set; }
        public virtual Verificacion IdvNavigation { get; set; }
    }
}
