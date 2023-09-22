using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.Administracion
{
    public class TipoDocumento: Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoDocumento { get; set; }
        public required string Nombre { get; set; }
        public Boolean activo { get; set; } = true;
        public Boolean mostrar { get; set; } = true;
        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
