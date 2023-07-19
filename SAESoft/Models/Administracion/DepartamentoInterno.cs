using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAESoft.Models.Comunes;

namespace SAESoft.Models.Administracion
{
    public class DepartamentoInterno:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDepto { get; set; }
        public required string Nombre { get; set; }
        public int IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public virtual Nombre Empresa { get; set; }
    }
}
