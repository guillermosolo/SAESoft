using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SAESoft.Models.Importaciones;

namespace SAESoft.Models.Administracion
{
    public class Residencia: Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdResidencia { get; set; }
        public int IdTipo { get; set; }
        [ForeignKey("IdTipo")]
        public virtual Nombre Tipo { get; set; }
        public required string Nombre { get; set; }
        public string? Visa { get; set; }
        public required string Resolucion { get; set; }
        public required DateTime Vencimiento { get; set; }
    }
}
