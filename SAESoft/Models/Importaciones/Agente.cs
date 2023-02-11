using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAESoft.Models.Importaciones
{
    public class Agente:Audit
    {
        [Key]
        public int IdAgente { get; set; }
        public required string Nombres { get; set; }
        public required string Apellidos { get; set; }
        public Boolean Activo { get; set; }

        [NotMapped]
        public string NombreCompleto { get { return IdAgente.ToString() + " - " + Apellidos + ", " + Nombres; } set { } }
        public virtual ICollection<Importacion> Importaciones { get; set;}
    }
}
