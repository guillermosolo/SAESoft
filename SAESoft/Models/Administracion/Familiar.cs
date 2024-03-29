﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SAESoft.Models.Comunes;
using SAESoft.Models.Importaciones;

namespace SAESoft.Models.Administracion
{
    public class Familiar:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFamiliar { get; set; }
        public int IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        public virtual Empleado Empleado { get; set; }
        public int IdParentesco { get; set; }
        [ForeignKey("IdParentesco")]
        public virtual Nombre Parentesco { get; set; }
        public required string Nombres { get; set; }
        public required string Apellidos { get; set; }
        public DateTime FechaNac { get; set; }

        [StringLength(1)]
        [Column(TypeName = "char(1)")]
        [RegularExpression("[MF]")]
        public required string Genero { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
        public int? IdResidencia { get; set; }
        [ForeignKey("IdResidencia")]
        public virtual Residencia Residencia { get; set; }
        public int? AñosResidencia { get; set; } = null;
        public int? IdSeguroMedico { get; set; }
        [ForeignKey("IdSeguroMedico")]
        public virtual SeguroMedico SeguroMedico { get; set; }

        [NotMapped]
        public string NombreCompleto { get { return Nombres + " " + Apellidos; } set { } }
    }
}
