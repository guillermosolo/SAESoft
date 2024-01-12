using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAESoft.Models.Comunes;

namespace SAESoft.Models.Exportaciones
{
    public class Duca:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDuca { get; set; }
        public required string NumDuca { get; set; }
        public int IdTipoDuca { get; set; }
        [ForeignKey("IdTipoDuca")]
        public virtual Nombre TipoDuca { get; set; }
        public int IdLicencia { get; set; }
        [ForeignKey("IdLicencia")]
        public virtual Licencia Licencia { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdDucaRef { get; set; }
        [ForeignKey("IdDuca")]
        public virtual Duca DucaRef { get; set; }
        public virtual ICollection<Duca> Ducas { get; set; }
    }
}
