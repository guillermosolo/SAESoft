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
    public class EmpIncentivos:Audit,ICloneable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpIncentivo { get; set; }
        public required string Codigo { get; set; }
        public required string Nombres { get; set; }
        public required string Apellidos { get; set; }
        [Column(TypeName = "Date")]
        public DateTime FechaIngreso { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? FechaBaja { get; set; }
        [Column(TypeName = "money")]
        public decimal BaseCalculo { get; set; } = decimal.Zero;
        public int IdDepto { get; set; }
        [ForeignKey("IdDepto")]
        public virtual DeptoIncentivo DeptoIncentivos { get; set; } = null!;
        public virtual ICollection<Asistencia> Asistencias { get; set; }
        public virtual ICollection<HistIncentivos> HistIncentivos { get; set; }
        public virtual ICollection<EvaluacionDetalle> Evaluaciones { get; set; }
        [NotMapped]
        public string NombreCompleto { get { return Apellidos + ", " + Nombres; } set { } }

        public object Clone()
        {
            EmpIncentivos clone = (EmpIncentivos)this.MemberwiseClone();
            clone.HistIncentivos = new List<HistIncentivos>(this.HistIncentivos.Select(h => new HistIncentivos
            {
                IdDepto = h.IdDepto,
                DeptoIncentivos = h.DeptoIncentivos, // Aquí, si DeptoIncentivos también necesita clonación profunda, hazlo
                IdEmpleado = h.IdEmpleado,
                FechaInicio = h.FechaInicio,
                BaseCalculo = h.BaseCalculo,
                FechaCreacion = h.FechaCreacion,
                IdUsuarioCreacion = h.IdUsuarioCreacion,
                Autorizacion = h.Autorizacion
            }));
            return clone;
        }
    }
}
