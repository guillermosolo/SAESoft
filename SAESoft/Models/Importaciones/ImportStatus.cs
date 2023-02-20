using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.Importaciones
{
    public class ImportStatus : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdImportStatus {get; set;}
        public string Descripcion { get; set;}
        public uint orden { get; set; }
        public char Via { get; set; }

        public Boolean ultimo { get; set; } = false;
        public ICollection<Importacion> Importaciones { get; set;}
    }
}
