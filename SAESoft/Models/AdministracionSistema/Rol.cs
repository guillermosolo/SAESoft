using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SAESoft.Models.AdministracionSistema
{
    [Index(nameof(Nombre), IsUnique = true)]
    public class Rol:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRol { get; set; }
        public required string Nombre { get; set; }
        public Boolean Habilitado { get; set; } = true;
        public virtual ICollection<Usuario> Usuarios { get; set; } = null!;
        public virtual ICollection<Permiso> Permisos { get; set; } = null!;
    }
}
