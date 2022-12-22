using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace SAESoft.Models.AdministracionSistema
{
    [Index(nameof(Nombre), IsUnique = true)]
    public class Modulo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdModulo { get; set; }
        public required string Nombre { get; set; }
        public Boolean Habilitado { get; set; } = true;
        public DateTime FechaCreacion { get; set; }
        public int? IdUsuarioCreacion { get; set; }
        public DateTime? FechaUltimaMod { get; set; }
        public int? IdUsuarioMod { get; set; }
    }
}
