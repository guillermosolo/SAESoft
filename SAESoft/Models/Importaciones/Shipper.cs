using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SAESoft.Models.Importaciones
{
    [Index(nameof(Nombre), IsUnique = true)]
    public class Shipper:Audit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdShipper { get; set; }
        public required string Nombre { get; set; }
        public Boolean Aereo { get; set; }
        public Boolean Maritimo { get; set; }
        public Boolean Terrestre { get; set; }  
    }
}
