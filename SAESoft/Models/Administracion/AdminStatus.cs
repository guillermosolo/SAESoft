using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
