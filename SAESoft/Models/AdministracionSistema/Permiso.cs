using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.AdministracionSistema
{
    public class Permiso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPermiso { get; set; }
        public required string Nombre { get; set; }
        public int IdModulo { get; set; }
        [ForeignKey("IdModulo")]
        public virtual Modulo Modulo { get; set; } = null!;

        public virtual ICollection<Rol> Roles { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public int? IdUsuarioCreacion { get; set; }
        public DateTime? FechaUltimaMod { get; set; }
        public int? IdUsuarioMod { get; set; }
    }
}
