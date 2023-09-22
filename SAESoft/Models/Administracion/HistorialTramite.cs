using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.Administracion
{
    public class HistorialTramite: Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHistorial { get; set; }
        public int IdTramite { get; set; }
        [ForeignKey("IdTramite")]
        public virtual Tramite Tramite { get; set; }
        public int IdStatus { get; set; }
        [ForeignKey("IdStatus")]
        public virtual AdminStatus Status { get; set; }
        public DateTime fecha { get; set; }
    }
}
