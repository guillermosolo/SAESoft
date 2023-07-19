
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SAESoft.Models.Comunes
{
    [Index(nameof(Descripcion), nameof(IdGrupo), IsUnique = true)]
    public class Nombre : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNombre { get; set; }
        public required string Descripcion { get; set; }
        public int IdGrupo { get; set; }
        [ForeignKey("IdGrupo")]
        public virtual Grupo Grupo { get; set; } = null!;
    }
}
