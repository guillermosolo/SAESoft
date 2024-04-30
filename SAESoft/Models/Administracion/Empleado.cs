using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using SAESoft.Models.Comunes;

namespace SAESoft.Models.Administracion
{
    [Index(nameof(Codigo), IsUnique = true)]
    public class Empleado: Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpleado { get; set; }
        public required string Codigo { get; set; }
        public int IdDepto { get; set; }
        [ForeignKey("IdDepto")]
        public virtual DepartamentoInterno Departamento { get; set; }
        public required string Nombres { get; set; }
        public required string Apellidos { get; set; }

        [StringLength(1)]
        [Column(TypeName = "char(1)")]
        [RegularExpression("[MF]")]
        public required string Genero { get; set; }

        [StringLength(1)]
        [Column(TypeName = "char(1)")]
        [RegularExpression("[CS]")]
        public required string EstadoCivil { get; set; }
        public required string Alias { get; set; }
        public required string NombreCoreano { get; set; }
        public required DateTime FechaNac { get; set; } 
        public required DateTime FechaIngreso { get; set; }
        public DateTime? FechaBaja { get; set; }

        public int IdPuesto { get; set; }
        [ForeignKey("IdPuesto")]
        public virtual Nombre Puesto { get; set; }
        public int? IdResidencia { get; set; }
        [ForeignKey("IdResidencia")]
        public virtual Residencia Residencia { get; set; }
        public int? IdPermisoTrabajo { get; set; }
        [ForeignKey("IdPermisoTrabajo")]
        public virtual PermisoTrabajo PermisoTrabajo { get; set; }
        public int? IdContrato { get; set; }
        [ForeignKey("IdContrato")]
        public virtual Contrato Contrato { get; set; }
        public int? IdSeguroVehiculo { get; set; }
        [ForeignKey("IdSeguroVehiculo")]
        public virtual SeguroVehiculo SeguroVehiculo { get; set; }
        public int? IdSeguroMedico { get; set; }
        [ForeignKey("IdSeguroMedico")]
        public virtual SeguroMedico SeguroMedico { get; set; }
        public Boolean CuotaAnual { get; set; } = false;
        public Boolean BoletoOrnato { get; set; } = false;
        public Boolean Activo { get; set; } = true;
        public int? AñosResidencia { get; set; } = null;
        public virtual ICollection<Familiar> Familiares { get; set;}
        public virtual ICollection<Documento> Documentos { get; set;}
        public virtual ICollection<Nombramiento> Nombramientos { get; set; }
        [NotMapped]
        public string NombreCompleto { get { return Nombres + " " + Apellidos; } set { } }
    }
}
