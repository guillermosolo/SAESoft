using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.Incentivos
{
    public class Evaluacion:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvaluacion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public string Observaciones { get; set; }
        public Boolean finalizado { get; set; }
        public virtual ICollection<EvaluacionDetalle> Detalles { get; set; }
        public virtual ICollection<Asistencia> Asistencias { get; set; }
    }
}
