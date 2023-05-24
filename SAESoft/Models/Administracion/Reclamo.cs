using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAESoft.Models.Importaciones;

namespace SAESoft.Models.Administracion
{
    public class Reclamo : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReclamo { get; set; }
        public int IdEmpleado { get; set; }
        public Empleado Empleado { get; set; }
        public int? IdPaciente {get;set;}
        public Familiar Familiar { get; set; }
        public int IdTipo { get; set; }
        public Nombre TipoReclamo { get; set; }
        public int IdStatus { get; set; }
        public AdminStatus Status { get; set; }
        [Column(TypeName = "money")]
        public decimal Monto { get; set; }
        [Column(TypeName = "money")]
        public decimal Deducible { get; set; }
        [Column(TypeName = "money")]
        public decimal OtrosGastos { get; set; }
        [Column(TypeName = "money")]
        public decimal MontoReal { get; set; }
        public string? Cheque  { get; set; }
        public string? Observaciones { get; set; }
    }
}
