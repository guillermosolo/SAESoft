using Microsoft.EntityFrameworkCore;
using SAESoft.Models.AdministracionSistema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Models.Importaciones
{
    public class Importacion:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdImport { get; set; }
        public Guid Codigo { get; set; }
        public int IdShipper { get; set; }
        [ForeignKey("IdShipper")]
        public virtual Shipper Shipper { get; set; } = null!;
        public char Via { get; set; }
        public int IdNaviera { get; set; }
        [ForeignKey("IdNaviera")]
        public virtual Nombre Naviera { get; set; } = null!;
        public int? IdForwarder { get; set; }
        [ForeignKey("IdForwarder")]
        public virtual Nombre Forwarder { get; set; } = null!;
        public virtual ICollection<Contenedor> Contenedores { get; set; } = null!;
        public int? IdDestino { get; set; }
        [ForeignKey("IdDestino")]
        public virtual Nombre Destino { get; set; } = null!;
        public DateTime ETA { get; set; }
        public int? IdTerminal { get; set; }
        [ForeignKey("IdTerminal")]
        public virtual Nombre Terminal { get; set; } = null!;
        public virtual ICollection<Revision> Revisiones { get; set; } = null!;
        public virtual ICollection<BL> BL { get; set; } = null!;
        public int IdAduana { get; set; }
        [ForeignKey("IdAduana")]
        public virtual Aduana Aduana { get; set; } = null!;

        [Precision(14, 2)]
        public decimal monto;

        [Precision(14, 2)]
        public decimal mora;
        public int? IdAlmacenadora { get; set; }
        [ForeignKey("IdAlmacenadora")]
        public virtual Nombre Almacenadora { get; set; } = null!;
        public Boolean Consolidado { get; set; } = false;
        public int? IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; } = null!;

        public int IdImportStatus { get; set; }
        [ForeignKey("IdImportStatus")]
        public virtual ImportStatus ImportStatus { get; set; } = null!; 
        public virtual ICollection<ImportHistorial> ImportHistorial { get; set; } = null!;

        [Column(TypeName = "money")]
        public decimal? Monto { get; set; }

        [Column(TypeName = "money")]
        public decimal? Mora { get; set; }
    }
}
