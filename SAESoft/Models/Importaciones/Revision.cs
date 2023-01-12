using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace SAESoft.Models.Importaciones
{
    [Index(nameof(Descripcion), IsUnique = true)]
    public class Revision:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRevision { get; set; }
        public required string Descripcion { get; set; }
        public ICollection<Importacion> Importaciones { get; set; } = null!;
    }
}
