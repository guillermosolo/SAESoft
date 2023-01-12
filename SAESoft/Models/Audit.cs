using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models
{
    public class Audit
    {
        public DateTime FechaCreacion { get; set; }
        public int? IdUsuarioCreacion { get; set; }
        public DateTime? FechaUltimaMod { get; set; }
        public int? IdUsuarioMod { get; set; }
    }
}
