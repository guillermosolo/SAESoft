using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.Administracion
{
    public class Tramite:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTramite { get; set; }
        public int IdEmpleado { get; set; }
        public Empleado Empleado { get; set; }
        public int IdStatus { get; set; }
        public AdminStatus Status { get; set; }
        public int IdTipo { get; set; }
        public DateTime Fecha { get; set; }
        public string? Observaciones { get; set; }
    }
}
