using System;
using System.Collections.Generic;

#nullable disable

namespace ITSC.Models
{
    public partial class Verificacion
    {
        public Verificacion()
        {
            VerificacionDa = new HashSet<VerificacionDum>();
        }

        public int Idv { get; set; }
        public int? Idtec { get; set; }
        public int? Idc { get; set; }
        public DateTime? FechaR { get; set; }
        public string CartaRespuesta { get; set; }
        public string Estado { get; set; }

        public virtual Consulta IdcNavigation { get; set; }
        public virtual Trabajadore IdtecNavigation { get; set; }
        public virtual ICollection<VerificacionDum> VerificacionDa { get; set; }
    }
}
