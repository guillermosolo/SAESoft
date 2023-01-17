using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.Importaciones
{
    public class ImportHistorial:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHistorial { get; set; }
        public int IdImport { get; set; }
        [ForeignKey("IdImport")]
        public virtual Importacion Importacion { get; set; } = null!;
        public int IdImportStatus { get; set; }
        [ForeignKey("IdImportStatus")]
        public virtual ImportStatus ImportStatus { get; set; } = null!;
    }
}
