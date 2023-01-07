using Microsoft.EntityFrameworkCore;
using SAESoft.Models.AdministracionSistema;
using static SAESoft.Utilitarios.Password;

namespace SAESoft.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Rol rol = new Rol()
            {
                IdRol = 1, 
                Nombre = "Super Admin",
                FechaCreacion = DateTime.Now,
                IdUsuarioCreacion = 1
            };
            modelBuilder.Entity<Rol>()
                .HasData(rol);

            Usuario sa = new Usuario() {
                IdUsuario = 1,
                Nombres = "Super",
                Apellidos = "Admin",
                Email = "sa@sae-a.com",
                UserName = "sa",
                Password = ComputeHash("sa"),
                IdRol = 1,
                Activo = true,
                FechaCreacion = DateTime.Now,
                IdUsuarioCreacion= 1
            };

            modelBuilder.Entity<Usuario>()
                .HasData(sa);

            List<Modulo> modulos = new List<Modulo>()
            {
                new Modulo {IdModulo = 1,Nombre="MENÚ PRINCIPAL",FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new Modulo {IdModulo = 2,Nombre="ADMINISTRACIÓN DEL SISTEMA",FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new Modulo {IdModulo = 3,Nombre="IMPORTACIONES",FechaCreacion=DateTime.Now,IdUsuarioCreacion=1}
            };
            modelBuilder.Entity<Modulo>().HasData(modulos);

            List<Permiso> permisos = new List<Permiso>()
            {
                new Permiso{IdPermiso = 1, Nombre="VER.ADMINISTRACION SISTEMA",IdModulo = 1,FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new Permiso{IdPermiso = 2, Nombre="VER.IMPORTACIONES",IdModulo = 1,FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},

                new Permiso{IdPermiso = 11, Nombre="VER.USUARIOS",IdModulo = 2,FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new Permiso{IdPermiso = 12, Nombre = "CREAR.USUARIOS",IdModulo =2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 13, Nombre = "MODIFICAR.USUARIOS",IdModulo =2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 14, Nombre = "ELIMINAR.USUARIOS", IdModulo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 15, Nombre = "VER.ROLES", IdModulo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 16, Nombre = "CREAR.ROLES", IdModulo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 17, Nombre = "MODIFICAR.ROLES", IdModulo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 18, Nombre = "ELIMINAR.ROLES", IdModulo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 19, Nombre = "VER.PERMISOS", IdModulo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 20, Nombre = "CREAR.PERMISOS", IdModulo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 21, Nombre = "MODIFICAR.PERMISOS", IdModulo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 22, Nombre = "ELIMINAR.PERMISOS", IdModulo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 23, Nombre = "VER.MODULOS", IdModulo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 24, Nombre = "CREAR.MODULOS", IdModulo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 25, Nombre = "MODIFICAR.MODULOS", IdModulo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 26, Nombre = "ELIMINAR.MODULOS", IdModulo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},

                new Permiso{IdPermiso = 27, Nombre = "VER.DASHBOARD", IdModulo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 28, Nombre = "VER.MARITIMO", IdModulo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 29, Nombre = "VER.AEREO", IdModulo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
            };  
            modelBuilder.Entity<Permiso>().HasData(permisos);

            foreach(Permiso p in permisos)
            {
                modelBuilder.Entity<Rol>()
                            .HasMany(r=> r.Permisos)
                            .WithMany(r=>r.Roles)
                            .UsingEntity(j=>j.HasData(new { RolesIdRol = rol.IdRol, PermisosIdPermiso = p.IdPermiso }));
            }
        }
    }
}
