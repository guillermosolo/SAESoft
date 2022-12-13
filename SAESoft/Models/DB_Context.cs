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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>()
                .HasData(
                    new Rol {IdRol=1, Nombre = "Super Admin" }
                );

            modelBuilder.Entity<Usuario>()
                .HasData(
                new Usuario { IdUsuario=1, Nombres = "Super", Apellidos = "Admin", Email = "sa@sae-a.com", UserName = "sa", Password = Password.ComputeHash("sa"), IdRol = 1, Activo = true, FechaCreacion = DateTime.Now });
        }

    }
}
