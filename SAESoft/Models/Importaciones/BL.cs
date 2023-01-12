using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SAESoft.Models.Importaciones
{
    [Index(nameof(Numero), IsUnique = true)]
    public class BL : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdBL { get; set; }
        public required string Numero { get; set; }
        public int IdImportacion { get; set; }
        [ForeignKey("IdImportacion")]
        public virtual Importacion Importacion { get; set; } = null!;
    }
}
