using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
