using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SAESoft.Models.AdministracionSistema;
using Microsoft.EntityFrameworkCore;

namespace SAESoft.Models.Comunes
{
    [Index(nameof(Nombre), IsUnique = true)]
    public class Grupo : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGrupo { get; set; }
        public required string Nombre { get; set; }
        public int IdModulo { get; set; }
        [ForeignKey("IdModulo")]
        public virtual Modulo Modulo { get; set; } = null!;
        public virtual ICollection<Nombre> Nombres { get; set; } = null!;
    }
}
