using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace SAESoft.Models.Incentivos
{
    public class HistIncentivos:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHistorial { get; set; }
        public int IdDepto { get; set; }
        [ForeignKey("IdDepto")]
        public virtual DeptoIncentivo DeptoIncentivos { get; set; } = null!;
        public int IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        public virtual EmpIncentivos Empleado { get; set; } = null!;
        [Column(TypeName = "Date")]
        public DateTime FechaInicio { get; set; }
        [Column(TypeName = "money")]
        public required decimal BaseCalculo { get; set; }
        public required string Autorizacion { get; set; } = "Monto Inicial";
        public int? idEvaluacion { get; set; } = null;
    }
}
