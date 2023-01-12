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
    [Index(nameof(Nombre), IsUnique = true)]
    [Index(nameof(Abreviatura), IsUnique = true)]
    public class Aduana:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAduana { get; set; }
        public required string Nombre { get; set; }
        public required string Abreviatura { get; set; }
        [StringLength(2,MinimumLength = 2)]
        public required char Via { get; set; }
    }
}
