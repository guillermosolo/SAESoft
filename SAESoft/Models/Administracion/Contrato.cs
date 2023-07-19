using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SAESoft.Models.Comunes;

namespace SAESoft.Models.Administracion
{
    public class Contrato:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdContrato { get; set; }
        public required string Numero { get; set; }
        public int IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public virtual Nombre Empresa { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
