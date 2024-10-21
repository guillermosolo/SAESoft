using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SAESoft.Models.AdministracionSistema;

namespace SAESoft.Models.Incentivos
{
    public class DeptoIncentivo:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDepto { get; set; }
        public string Nombre { get; set;}
        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Encargado { get; set; }
        public Boolean Activo { get; set; } = true;
        public virtual ICollection<EmpIncentivos> Empleados { get; set; }
        public virtual ICollection<EvaluacionDetalle> EvalacionDetalles { get; set; }
    }
}
