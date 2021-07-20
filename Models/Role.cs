using System;
using System.Collections.Generic;

#nullable disable

namespace ITSC.Models
{
    public partial class Role
    {
        public Role()
        {
            Trabajadores = new HashSet<Trabajadore>();
        }

        public int Idr { get; set; }
        public string Roll { get; set; }

        public virtual ICollection<Trabajadore> Trabajadores { get; set; }
    }
}
