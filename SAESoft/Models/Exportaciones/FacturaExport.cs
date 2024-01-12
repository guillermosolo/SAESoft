using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAESoft.Models.Comunes;
using SAESoft.Models.Importaciones;

namespace SAESoft.Models.Exportaciones
{
    public class FacturaExport : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        [StringLength(15, MinimumLength = 5)]
        public required string Referencia { get; set; }
        public required string NoFactura { get; set; }
        public int IdTipoFactura { get; set; }
        [ForeignKey("IdTipoFactura")]
        public virtual Nombre TipoFactura { get; set; } = null;
        public int IdConsignatario { get; set; }
        [ForeignKey("IdConsignatario")]
        public virtual Nombre Consignatario  {get; set;}
        public int? IdAduana { get; set; }
        [ForeignKey("IdAduana")]
        public virtual Aduana Aduana { get; set; } = null;
        public int? IdModalidad { get; set; }
        [ForeignKey("IdModalidad")]
        public virtual Nombre? Modalidad { get; set; } = null;
        public int? IdExportador { get; set; }
        [ForeignKey("IdExportador")]
        public virtual Nombre Exportador { get; set; } = null;
        public int? IdLicencia { get; set; }
        [ForeignKey("IdLicencia")]
        public virtual Licencia Licencia { get; set; } = null;
        public DateTime? FechaAnulacion {  get; set; }
        [StringLength(15, MinimumLength = 5)]
        public string? NotaCredito { get; set; }
    }
}
