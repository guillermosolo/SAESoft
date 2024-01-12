using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.Exportaciones
{
    public class Licencia:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLicencia { get; set; }
        public required string NumLicencia { get; set; }
        public Guid Codigo { get; set; } = Guid.NewGuid();
        public DateTime Fecha {  get; set; }
        public virtual ICollection<FacturaExport> Facturas { get; set; }
        public virtual ICollection<Descargo> Descargos { get; set; }
        public virtual ICollection<Duca> Ducas { get; set; }
        public virtual ICollection<ComentFacExport> Comentarios { get; set; }
    }
}
