﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAESoft.Models.Comunes;

namespace SAESoft.Models.Administracion
{
    public class Reclamo : Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReclamo { get; set; }
        public int IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        public virtual Empleado Empleado { get; set; }
        public int? IdPaciente {get;set;}
        [ForeignKey("IdPaciente")]
        public virtual Familiar Familiar { get; set; }
        public int IdTipo { get; set; }
        [ForeignKey("IdTipo")]
        public virtual Nombre TipoReclamo { get; set; }
        public int IdStatus { get; set; }
        [ForeignKey("IdStatus")]
        public virtual AdminStatus Status { get; set; }
        [Column(TypeName = "money")]
        public decimal? Monto { get; set; }
        public int IdMoneda { get; set; }
        [ForeignKey("IdMoneda")]
        public virtual Moneda Moneda { get; set; }
        [Column(TypeName = "money")]
        public decimal? Deducible { get; set; }
        [Column(TypeName = "money")]
        public decimal? Coaseguro { get; set; }
        [Column(TypeName = "money")]
        public decimal? Timbres { get; set; }
        [Column(TypeName = "money")]
        public decimal? MontosNoCubiertos { get; set; }
        [Column(TypeName = "money")]
        public decimal? OtrosGastos { get; set; }
        [Column(TypeName = "money")]
        public decimal? MontoCheque { get; set; }
        public string? Cheque  { get; set; }
        public DateTime FechaRecibir { get; set; }
        public string? Observaciones { get; set; }
        public virtual ICollection<HistorialReclamo> Historial { get; set; }
    }
}
