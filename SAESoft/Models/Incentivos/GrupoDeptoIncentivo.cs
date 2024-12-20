using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SAESoft.Models.AdministracionSistema;

namespace SAESoft.Models.Incentivos
{
    public class GrupoDeptoIncentivo:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGrupo { get; set; }
        public string Nombre { get; set; }
        public Boolean Activo { get; set; } = true;
        public int? IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Encargado { get; set; }
        public virtual ICollection<DeptoIncentivo> Departamentos { get; set; }
    }
}
