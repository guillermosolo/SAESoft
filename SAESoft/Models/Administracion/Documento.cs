using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAESoft.Models.Importaciones;

namespace SAESoft.Models.Administracion
{
    public class Documento:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDocumento { get; set; }
        public int? IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        public virtual Empleado Empleado { get; set; }

        public int? IdFamiliar { get; set; }
        [ForeignKey("IdFamiliar")]
        public virtual Familiar Familiar { get; set; }
        public int IdTipo { get; set; }
        [ForeignKey("IdTipo")]
        public virtual TipoDocumento Tipo { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? Vencimiento { get; set; }
        public Boolean NoVence { get; set; }
    }
}
