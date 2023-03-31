using Microsoft.EntityFrameworkCore;
using SAESoft.Models.AdministracionSistema;
using SAESoft.Models.Importaciones;
using SAESoft.Utilitarios;
using System.Configuration;

namespace SAESoft.Models
{
    public class SAESoftContext : DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MSSQL_Test"].ConnectionString);
           //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Nombre> Nombres { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Aduana> Aduanas { get; set; }
        public DbSet<Terminal> Terminales { get; set; }
        public DbSet<Revision> Revisiones { get; set; }
        public DbSet<Importacion> Importaciones { get; set; }
        public DbSet<Poliza> Polizas { get; set; } 
        public DbSet<BL> BL { get; set; }
        public DbSet<Contenedor> Contenedores { get; set; }
        public DbSet<ImportStatus> ImportStatus { get; set; }
        public DbSet<ImportHistorial> ImportHistorial { get; set; }
        public DbSet<Agente> Agentes { get; set; }
        public DbSet<Pago> Pagos { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddRemoveOneToManyCascadeConvention();

            modelBuilder.ApplyConventions();

            modelBuilder.Seed();
        }

    }
}
