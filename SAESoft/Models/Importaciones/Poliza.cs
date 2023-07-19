using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using SAESoft.Models.Comunes;

namespace SAESoft.Models.Importaciones
{
    [Index(nameof(Numero), IsUnique = true)]
    public class Poliza : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPoliza { get; set; }
        public int IdBL { get; set; }
        [ForeignKey("IdBL")]
        public virtual BL BL { get; set; } = null!;
        public required string Numero { get; set; }
        public int? IdModalidad { get; set; }
        [ForeignKey("IdModalidad")]
        public virtual Nombre Modalidad { get; set; } = null!;
        public string? Observaciones { get; set; }
    }
}
