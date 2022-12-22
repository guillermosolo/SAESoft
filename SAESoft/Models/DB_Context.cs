using Microsoft.EntityFrameworkCore;
using SAESoft.Models.AdministracionSistema;
using SAESoft.Utilitarios;
using System.Configuration;

namespace SAESoft.Models
{
    public class DB_Context : DbContext
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddRemoveOneToManyCascadeConvention();

            modelBuilder.ApplyConventions();

            modelBuilder.Seed();
        }

    }
}
