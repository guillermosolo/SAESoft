﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SAESoft.Models.AdministracionSistema
{
    [Index(nameof(Nombre), IsUnique = true)]
    public class Permiso:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPermiso { get; set; }
        public required string Nombre { get; set; }
        public int IdModulo { get; set; }
        [ForeignKey("IdModulo")]
        public virtual Modulo Modulo { get; set; } = null!;

        public virtual ICollection<Rol> Roles { get; set; } = null!;
    }
}
