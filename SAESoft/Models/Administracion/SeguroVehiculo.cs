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
    public class SeguroVehiculo:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVehiculo { get; set; }
        public required string Marca { get; set; }
        public required string Color { get; set; }
        public required string Placa { get; set; }
        public int IdAseguradora { get; set; }
        [ForeignKey("IdAseguradora")]
        public virtual Nombre Aseguradora { get; set; }
        public required string Poliza { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Vencimiento { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Prima { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Deducible { get; set;}
        public virtual Empleado Empleado { get; set; }
    }
}
