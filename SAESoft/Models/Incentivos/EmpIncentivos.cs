using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAESoft.Models.Importaciones;
using Microsoft.EntityFrameworkCore;

namespace SAESoft.Models.Incentivos
{
    [Index(nameof(Codigo), IsUnique = true)]
    public class EmpIncentivos:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpIncentivo { get; set; }
        public required string Codigo { get; set; }
        public required string Nombres { get; set; }
        public required string Apellidos { get; set; }
        [Column(TypeName = "money")]
        public decimal BaseCalculo { get; set; } = decimal.Zero;
        public int IdDepto { get; set; }
        [ForeignKey("IdDepto")]
        public virtual DeptoIncentivo DeptoIncentivos { get; set; } = null!;
        public virtual ICollection<Asistencia> Asistencias { get; set; }
    }
}
