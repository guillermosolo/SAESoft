using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.Administracion
{
    public class SeguroMedico: Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMedico { get; set; }
        public required string Certificado { get; set; }
        public required string Carnet { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Vencimiento { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Familiar Familiar { get; set; }
    }
}
