using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using SAESoft.Models.Comunes;

namespace SAESoft.Models.AdministracionSistema
{
    [Index(nameof(Nombre), IsUnique = true)]
    public class Modulo : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdModulo { get; set; }
        public required string Nombre { get; set; }
        public Boolean Habilitado { get; set; } = true;
        public virtual ICollection<Permiso> Permisos { get; set; } = null!;
        public virtual ICollection<Grupo> Grupos { get; set; } = null!;
    }
}
