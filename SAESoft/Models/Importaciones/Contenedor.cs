using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SAESoft.Models.Importaciones
{
    public class Contenedor : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdContenedor { get; set; }
        public required string Numero { get; set; }
        public int IdImportacion { get; set; }
        [ForeignKey("IdImportacion")]
        public virtual Importacion Importacion { get; set; } = null!;
        public string? Cabezal { get; set; }
        public string? Furgon { get; set; }
        [ForeignKey("IdPago")]
        public int? IdPago { get; set; }
        public virtual Pago Pago { get; set; }
    }
}
