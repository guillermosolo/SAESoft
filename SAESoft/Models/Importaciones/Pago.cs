using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.Importaciones
{
    public class Pago:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPago { get; set; }
        public int IdContenedor { get; set; }
        [ForeignKey("IdContenedor")]
        public virtual Contenedor Contenedor { get; set; } = null!;
        [Column(TypeName = "money")]
        public decimal MontoAlmacenaje { get; set; } = decimal.Zero;

        [Column(TypeName = "money")]
        public decimal MontoDemora { get; set; } = decimal.Zero;
    }
}
