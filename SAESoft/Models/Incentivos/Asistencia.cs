using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.Incentivos
{
    public class Asistencia: Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAsistencia { get; set; }
        public int IdEvaluacion { get; set; }
        [ForeignKey("IdEvaluacion")]
        public virtual Evaluacion Evaluacion { get; set; } = null!;
        public int IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        public virtual EmpIncentivos Empleado { get; set; } = null!;
        public int Tardanza { get; set; }
        public int Permiso { get; set; }
        public int Ausente { get; set; }
        public int Porcentaje { get; set; }
    }
}
