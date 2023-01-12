using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAESoft.Models.AdministracionSistema;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SAESoft.Models.Importaciones
{
    [Index(nameof(Descripcion), IsUnique = true)]
    public class Nombre:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNombre { get; set; }
        public required string Descripcion { get; set; }
        public int IdGrupo { get; set; }
        [ForeignKey("IdGrupo")]
        public virtual Grupo Grupo { get; set; } = null!;
    }
}
