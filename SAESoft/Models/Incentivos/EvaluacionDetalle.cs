using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.Incentivos
{
    public class EvaluacionDetalle : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvaluacionDetalle { get; set; }
        public int IdEvaluacion { get; set; }
        [ForeignKey("IdEvaluacion")]
        public virtual Evaluacion Evaluacion { get; set; } = null!;
        public int IdDepto { get; set; }
        [ForeignKey("IdDepto")]
        public virtual DeptoIncentivo Departamento { get; set; } = null!;
        public int IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        public virtual EmpIncentivos Empleado { get; set; } = null!;
        [Column(TypeName = "money")]
        public decimal BaseCalculo { get; set; } = decimal.Zero;
        public int Asistencia { get; set; }
        public int Actitud { get; set; }
        public int Cooperacion { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Extra { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Total { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal DiasProporcional { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Proporcional { get; set; }
    }
}
