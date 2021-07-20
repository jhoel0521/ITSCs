using System;
using System.Collections.Generic;

#nullable disable

namespace ITSC.Models
{
    public partial class Tramite
    {
        public Tramite()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int Idt { get; set; }
        public string NombreT { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
