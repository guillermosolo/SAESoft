using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.Incentivos
{
    public class Suspension:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSuspension { get; set; }
        public int IdDepto { get; set; }
        [ForeignKey("IdDepto")]
        public virtual DeptoIncentivo DeptoIncentivos { get; set; } = null!;
        public int IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        public virtual EmpIncentivos Empleado { get; set; } = null!;
        [Column(TypeName = "Date")]
        public DateTime FechaInicio { get; set; }
        [Column(TypeName = "Date")]
        public DateTime FechaFin { get; set; }
        public required string Observaciones { get; set; }
        public Boolean Activo { get; set; } = true;
    }
}
