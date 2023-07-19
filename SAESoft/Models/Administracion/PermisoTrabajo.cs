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
    public class PermisoTrabajo:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPermiso { get; set; }
        public int IdTipo { get; set; }
        [ForeignKey("IdTipo")]
        public virtual Nombre Tipo { get; set; }
        public required string Resolucion { get; set; }
        public required DateTime Inicio { get; set; }
        public required DateTime Vencimiento { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
