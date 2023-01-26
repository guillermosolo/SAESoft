

namespace SAESoft.Models
{
    public abstract class Audit
    {
        public DateTime FechaCreacion { get; set; }
        public int? IdUsuarioCreacion { get; set; }
        public DateTime? FechaUltimaMod { get; set; }
        public int? IdUsuarioMod { get; set; }
    }
}
