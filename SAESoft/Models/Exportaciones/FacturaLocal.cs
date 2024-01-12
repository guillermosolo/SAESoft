using SAESoft.Models.Comunes;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SAESoft.Models.Exportaciones
{
    public class FacturaLocal: Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        [StringLength(15, MinimumLength = 5)]
        public required string Referencia { get; set; }
        public required string NoFactura { get; set; }
        public int IdTipoFactura { get; set; }
        [ForeignKey("IdTipoFactura")]
        public virtual Nombre TipoFactura { get; set; } = null;
        public int? IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public virtual Nombre Empresa { get; set; } = null;
        public string Cliente { get; set; }
        public string? Comentarios { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        [StringLength(15, MinimumLength = 5)]
        public string? NotaCredito { get; set; }
    }
}
