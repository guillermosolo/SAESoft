using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAESoft.Models.Importaciones;

namespace SAESoft.Models.Comunes
{
    public class Moneda : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMoneda { get; set; }
        public required string Nombre { get; set; }
        public required string Abreviatura { get; set; }
        public required string Simbolo { get; set; }
        [NotMapped]
        public string NombreMoneda { get { return Nombre + " (" + Simbolo + ")"; } set { } }
    }
}
