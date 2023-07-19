using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SAESoft.Models.Administracion
{
    public class AdminStatus:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdStatus { get; set; }
        public string Nombre { get; set; }
        public int Orden { get; set; }
        [RegularExpression("^[RT]$")]
        public char Tipo { get; set; }
        public int IdTipoDoc { get; set; }
        [ForeignKey("IdTipoDoc")]
        public virtual TipoDocumento TipoDocumento { get; set; }
        public Boolean Ultimo { get; set; } = false;
    }
}
