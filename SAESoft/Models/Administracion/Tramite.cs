using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAESoft.Models.Comunes;

namespace SAESoft.Models.Administracion
{
    public class Tramite:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTramite { get; set; }
        public int IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        public virtual Empleado Empleado { get; set; }
        public int? IdInteresado { get; set; }
        [ForeignKey("IdInteresado")]
        public virtual Familiar Familiar { get; set; }
        public int IdStatus { get; set; }
        [ForeignKey("IdStatus")]
        public virtual AdminStatus Status { get; set; }
        public int IdTipo { get; set; }
        [ForeignKey("IdTipo")]
        public virtual TipoDocumento Tipo { get; set; }    
        public string? Observaciones { get; set; }
        public DateTime? Cita { get; set; }
        public string? NumeroSolicitud { get; set; }
        public virtual ICollection<HistorialTramite> Historial { get; set; }
    }
}
