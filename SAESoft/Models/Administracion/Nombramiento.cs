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
    public class Nombramiento:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNombramiento { get; set; }
        public int? IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        public virtual Empleado Empleado { get; set; }
        public int IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public virtual Nombre Empresa { get; set; }
        public int IdTipo { get; set; }
        [ForeignKey("IdTipo")]
        public virtual Nombre Tipo { get; set; }
        public required string Registro { get; set; }
        public required string Folio { get; set; }
        public required string Libro { get; set; }
        public required string Expediente { get; set; }
        public DateTime Inscripcion { get; set; }
        public DateTime Vencimiento { get; set; }
        public DateTime? Cancelacion { get; set; }
        public Boolean Cancelado { get; set; }
    }
}
