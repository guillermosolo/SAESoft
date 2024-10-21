using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAESoft.Models.AdministracionSistema;

namespace SAESoft.Models.Comunes
{
    public class Firma: Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFirma { get; set; }
        public int IdModulo { get; set; }
        [ForeignKey("IdModulo")]
        public virtual Modulo Modulo { get; set; } = null!;
        public string puesto { get; set; }
        public string firma { get; set; }
    }
}
