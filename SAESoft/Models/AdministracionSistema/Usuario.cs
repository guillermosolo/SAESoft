using Microsoft.EntityFrameworkCore;
using SAESoft.Models.Incentivos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.AdministracionSistema
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(UserName), IsUnique = true)]
    public class Usuario:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        public required string Nombres { get; set; }
        public required string Apellidos { get; set; }
        public required string Email { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public int IdRol { get; set; }
        [ForeignKey("IdRol")]
        public virtual Rol Rol { get; set; } = null!;
        public Boolean Activo { get; set; }
        public virtual ICollection<GrupoDeptoIncentivo> GrupoDeptoIncentivos { get; set; }
        public virtual ICollection<DeptoIncentivo> DeptoIncentivos { get; set; }
    }
}
