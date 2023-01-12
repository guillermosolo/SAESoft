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
    public class Terminal:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTerminal { get; set; }
        public required string Nombre { get; set; }
        public required char Via { get; set; }
    }
}
