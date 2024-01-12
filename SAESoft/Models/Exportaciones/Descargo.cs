using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.Exportaciones
{
    public class Descargo:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDescargo { get; set; }
        public required string NumDescargo { get; set; }
        public DateTime Fecha { get; set; }
        public int IdLicencia { get; set; }
        [ForeignKey("IdLicencia")]
        public virtual Licencia Licencia { get; set; }
        public Boolean final { get; set; } = false;
    }
}
