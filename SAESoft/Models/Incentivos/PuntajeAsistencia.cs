using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.StyledXmlParser.Node;

namespace SAESoft.Models.Incentivos
{
    public class PuntajeAsistencia:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPuntajeAsistencia { get; set; }
        public int Minimo { get; set; }
        public int Maximo { get; set; }
        public int Porcentaje {  get; set; }
        public DateTime FechaInicio {  get; set; }
        public DateTime? FechaFin {  get; set; }

    }
}
