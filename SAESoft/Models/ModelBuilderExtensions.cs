using Microsoft.EntityFrameworkCore;
using SAESoft.Models.AdministracionSistema;
using SAESoft.Models.Importaciones;
using System.Net.Http.Headers;
using static SAESoft.Utilitarios.Password;

namespace SAESoft.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
           List<Rol> roles = new List<Rol>()
            {
               new Rol {IdRol = 1,Nombre = "Super Admin",FechaCreacion = DateTime.Now,IdUsuarioCreacion = 1 },
               new Rol {IdRol = 2,Nombre = "Digitador Importaciones",FechaCreacion=DateTime.Now,IdUsuarioCreacion=1}
            };
            modelBuilder.Entity<Rol>()
                .HasData(roles);

            Usuario sa = new Usuario()
            {
                IdUsuario = 1,
                Nombres = "Super",
                Apellidos = "Admin",
                Email = "sa@sae-a.com",
                UserName = "sa",
                Password = ComputeHash("sa"),
                IdRol = 1,
                Activo = true,
                FechaCreacion = DateTime.Now,
                IdUsuarioCreacion = 1
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
                new Permiso{IdPermiso = 29, Nombre = "CREAR.MARITIMO",IdModulo =3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 30, Nombre = "MODIFICAR.MARITIMO",IdModulo =3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 31, Nombre = "ELIMINAR.MARITIMO", IdModulo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 32, Nombre = "VER.AEREO", IdModulo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 33, Nombre = "CREAR.AEREO",IdModulo =3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 34, Nombre = "MODIFICAR.AEREO",IdModulo =3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Permiso{IdPermiso = 35, Nombre = "ELIMINAR.AEREO", IdModulo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
            };
            modelBuilder.Entity<Permiso>().HasData(permisos);

            Rol rol = roles.FirstOrDefault(r => r.IdRol ==1);
            foreach (Permiso p in permisos)
            {
                modelBuilder.Entity<Rol>()
                            .HasMany(r => r.Permisos)
                            .WithMany(r => r.Roles)
                            .UsingEntity(j => j.HasData(new { RolesIdRol = rol.IdRol, PermisosIdPermiso = p.IdPermiso }));
            }

            Rol di = roles.FirstOrDefault(r => r.IdRol == 2);
            List<Permiso> permisosDI = new List<Permiso>();
            permisosDI = permisos.Where(p => new[] { 2, 27, 28, 30, 32, 34 }.Contains(p.IdPermiso)).ToList();
            foreach (Permiso p in permisosDI)
            {
                modelBuilder.Entity<Rol>()
                            .HasMany(r => r.Permisos)
                            .WithMany(r => r.Roles)
                            .UsingEntity(j => j.HasData(new { RolesIdRol = di.IdRol, PermisosIdPermiso = p.IdPermiso }));
            }

            List<Grupo> grupos = new List<Grupo>
            {
                new Grupo{IdGrupo=1,Nombre="EMPRESA",IdModulo=3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Grupo{IdGrupo=2,Nombre="FORWARDER",IdModulo=3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Grupo{IdGrupo = 3, Nombre = "DESTINO", IdModulo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Grupo{IdGrupo = 4, Nombre = "MODALIDAD", IdModulo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Grupo{IdGrupo = 5, Nombre = "ALMACENADORA", IdModulo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
            };
            modelBuilder.Entity<Grupo>().HasData(grupos);

            List<Nombre> nombres = new List<Nombre>
            {
                new Nombre{IdNombre=1,Descripcion="SEABOARD",IdGrupo=1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 2, Descripcion = "ONE LINE ", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 3, Descripcion = "CROWLEY", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 4, Descripcion = "MAERSK", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 5, Descripcion = "EVERGREEN", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 6, Descripcion = "HYUNDAI", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 7, Descripcion = "CHIQUITA", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 8, Descripcion = "WAN HAI", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 9, Descripcion = "HMM GLOBAL", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 10, Descripcion = "ATLANTIC", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 11, Descripcion = "SEALAND", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 12, Descripcion = "CMA CGM", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 13, Descripcion = "EXPEDITORS", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 14, Descripcion = "YANG MIN", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 15, Descripcion = "TRANSPORTES TRANSREYES", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 16, Descripcion = "CENTRASERVI S.A. DE C.V", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 17, Descripcion = "TRANSPORTES LOS ROBLES", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 18, Descripcion = "LOGISTRANS S.A.", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 19, Descripcion = "TRANSPORTES VILLEDA", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 20, Descripcion = "INTERNATIONAL CARGO", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 21, Descripcion = "CROWLEY LOGISTIC", IdGrupo = 1, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre=22,Descripcion="BLUE LOGISTC ",IdGrupo=2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 23, Descripcion = "DHL", IdGrupo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 24, Descripcion = "DONGSUE", IdGrupo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 25, Descripcion = "AVIANCA ", IdGrupo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 26, Descripcion = "TACA INTERNACIONAL", IdGrupo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 27, Descripcion = "FEDEX", IdGrupo = 2, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 28, Descripcion = "BODEGA ACCESORIOS", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 29, Descripcion = "BODEGA DE STOCKS", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 30, Descripcion = "BODEGA DE HILO PALIN", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 31, Descripcion = "CENTEXSA 2", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 32, Descripcion = "HANAH TRADING", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 33, Descripcion = "CENTEXSA", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 34, Descripcion = "JS TEXTILES", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 35, Descripcion = "J.W.TEXTILES", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 36, Descripcion = "JJ TRADING", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 37, Descripcion = "K&H", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 38, Descripcion = "KNITOPIA , S.A.", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 39, Descripcion = "KOA MODAS", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 40, Descripcion = "K.P TEXTILE", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 41, Descripcion = "PANTEX", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 42, Descripcion = "S&G", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 43, Descripcion = "SAE-A TEXPIA", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 44, Descripcion = "SAE-A TEXPIA 2", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 45, Descripcion = "SAE-A TEXPÍA 3", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 46, Descripcion = "TEXSION", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 47, Descripcion = "TEXTILES CHANG WOO", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 48, Descripcion = "WINNERS", IdGrupo = 3, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre=49,Descripcion="MI",IdGrupo=4, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 50, Descripcion = "ID", IdGrupo = 4, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 51, Descripcion = "MA", IdGrupo = 4, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 52, Descripcion = "DV", IdGrupo = 4, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 53, Descripcion = "DI", IdGrupo = 4, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 54, Descripcion = "MQ", IdGrupo = 4, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 55, Descripcion = "DS", IdGrupo = 4, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 56, Descripcion = "ALMAGUATE", IdGrupo = 5, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Nombre{IdNombre = 57, Descripcion = "ALSERSA", IdGrupo = 5, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
            };
            modelBuilder.Entity<Nombre>().HasData(nombres);

            List<Revision> revisiones = new List<Revision>
            {
                new Revision{IdRevision = 1, Descripcion = "SGAIA", FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Revision{IdRevision = 2, Descripcion = "DIPAFRONT", FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Revision{IdRevision = 3, Descripcion = "MAGA",FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Revision{IdRevision = 4, Descripcion = "RAYOS X",FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Revision{IdRevision = 5, Descripcion = "SELECTIVO ROJO",FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
            };
            modelBuilder.Entity<Revision>().HasData(revisiones);   

            List<Shipper> shippers = new List<Shipper>
            {
                new Shipper{IdShipper=1,Nombre="ANTEX KNITTING MILLS",Aereo=true,Maritimo=true,Terrestre=true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper=2,Nombre="BOHOTEX CO, LTD",Aereo=true,Maritimo=true,Terrestre=true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper=3,Nombre="BROS MACAO COMERCIAL",Aereo=true,Maritimo=false,Terrestre=false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper=4,Nombre="CHAKIM SRL",Aereo=true,Maritimo=true,Terrestre=true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper=5,Nombre="CHINA JUNYE TEXTILE",Aereo=true,Maritimo=false,Terrestre=false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper=6,Nombre="COLOR & TOUCH VINA CO.,LTD",Aereo=true,Maritimo=true,Terrestre=true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper=7,Nombre="DAP AMERICA INC",Aereo=true,Maritimo=false,Terrestre=false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper=8,Nombre="DONGGUAN TEXWINCA",Aereo=true,Maritimo=true,Terrestre=true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper=9,Nombre="HENIX FAR EAST",Aereo=true,Maritimo=true,Terrestre=true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper=10,Nombre="JUNGWOO VINA",Aereo=true,Maritimo=false,Terrestre=false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 11, Nombre = "KAN HIM PIECE", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 12, Nombre = "KEER AMERICA", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 13, Nombre = "MAINETTI EASTERN CHINA", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 14, Nombre = "MANH DAT MANUFACTURE", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 15, Nombre = "NICE DYEING FACTORY", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 16, Nombre = "OAK HNI", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 17, Nombre = "OCEAN NETWORK EXPRESS", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 18, Nombre = "PACIFIC TEXTILES", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 19, Nombre = "PARKDALE MILLS", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 20, Nombre = "PHU BAI SPINNING MILL", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 21, Nombre = "PT TOKAI TEXPRINT", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 22, Nombre = "PT. WIN TEXTILE", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 23, Nombre = "S&H GLOBAL, S.A.", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 24, Nombre = "SAE-A DOMINICANA", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 25, Nombre = "SAE-A EINS", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 26, Nombre = "SAE-A SPINNING, S.A.", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper=27,Nombre="SAE-A TRADING",Aereo=true,Maritimo=true,Terrestre=true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 28, Nombre = "SAMIL VINA", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 29, Nombre = "SEJIN SILICONE USA", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 30, Nombre = "SEWANG VINA", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 31, Nombre = "SHAOXING QIONGHUA TRADING CO.,LTD", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 32, Nombre = "SUNG BU VINA", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 33, Nombre = "SUNGPIL KANG", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 34, Nombre = "VN JUNGWOO CHINA", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 35, Nombre = "YAMATO USA", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 36, Nombre = "YANG JI INTERNATIONAL", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 37, Nombre = "YKK VIETNAM", Aereo = true, Maritimo = false, Terrestre = false, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper=38,Nombre="ACHROMA",Aereo=false,Maritimo=true,Terrestre=true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 39, Nombre = "ALVANON HK LTD", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 40, Nombre = "ALPINE", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 41, Nombre = "BRAND ID HK", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 42, Nombre = "BROS EASTERN CO", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 43, Nombre = "AVERY DENNISON", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 44, Nombre = "CENTURY INTERNATIONAL", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 45, Nombre = "BUHLER QUALITY YARNS CORP", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 46, Nombre = "COLOR SOLUTION", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 47, Nombre = "CONG TY TNHH", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 48, Nombre = "CRYSTAL TOWN LIMITED", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 49, Nombre = "CS CENTRAL AMERICA S.A. DE C.V.", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 50, Nombre = "DAEIL GAGONG", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 51, Nombre = "DAESONG LABTECH", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 52, Nombre = "DATACOLOR TECHNOLOGY", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 53, Nombre = "DESERT EMPIRE", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 54, Nombre = "DESICCA, LLCS", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 55, Nombre = "DETAILTEX", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 56, Nombre = "DICKS SPORTING", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 57, Nombre = "DONG HING LABEL", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 58, Nombre = "DURKOPP ADLER", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 59, Nombre = "DYSTAR LP DBA COLOR", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 60, Nombre = "E TEXTINT CORP", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 61, Nombre = "FAVORABLE TECHNOLOGY", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 62, Nombre = "EMBSENSE TEXTILE", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 63, Nombre = "FINE LINE TECHNO", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 64, Nombre = "EMSIG MANUFACTURING", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 65, Nombre = "FLASH GLOBAL GSC", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 66, Nombre = "FRANCIA HELENA YATE", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 67, Nombre = "FREUDENBERG", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 68, Nombre = "GAP INTERNATIONAL", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 69, Nombre = "HASBUN SILHY", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 70, Nombre = "HANSAE INTERNATIONAL", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 72, Nombre = "HHH VIETNAM CO LTD", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 73, Nombre = "INVISIN", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 74, Nombre = "JD LINK INC", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 80, Nombre = "KEUN YONG MACHINERY", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 81, Nombre = "KWIN VIET HAN CO., LTD", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 82, Nombre = "LECTRA SYSTEMES S,A", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 83, Nombre = "LONG JIA HAO", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 84, Nombre = "M TO M COMPORATION", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 85, Nombre = "MAINETTI VIETNAM", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 86, Nombre = "MARUWA CO., LTD", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 87, Nombre = "MEI SHENG ", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 88, Nombre = "NEMTEX S.A. DE C.V.", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 89, Nombre = "NEXGEN PACKAGING", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 90, Nombre = "OAK HNF", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 91, Nombre = "OCTANES", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 92, Nombre = "OPTIMER BRANDS", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 93, Nombre = "ORDELY INDUSTRIAL", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 94, Nombre = "PAXAR CHINA LIMITED", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 95, Nombre = "PETTENATI CENTRO", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 96, Nombre = "PRIDE PERFORMANCE", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 97, Nombre = "PT ANYTAPE INDO", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 98, Nombre = "R-PAC VIETNAM", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 99, Nombre = "S&S INDUSTRIES, S DE R.L", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 100, Nombre = "SAE A TECHNOTEX", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 101, Nombre = "SAE-A SPINNING, S.R.L", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 102, Nombre = "SAE-A TEXTUFIL", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 104, Nombre = "SAE-A VIETNAM", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper=105,Nombre="SHINING LABELS",Aereo=false,Maritimo=true,Terrestre=true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 106, Nombre = "SILVER PRINTING", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 107, Nombre = "SML DOMINICANA", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 108, Nombre = "SML HONG KONG ", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 109, Nombre = "SML VIETNAM", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 110, Nombre = "SOJI COLORWORKS", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 111, Nombre = "STAPROS INDUSTRIAL", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 112, Nombre = "SUNLINE", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 113, Nombre = "SWISSTEX DIRECT", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 114, Nombre = "SYNIGENCE TRADING", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 115, Nombre = "TEXHONG ", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 116, Nombre = "UNITED TEXTILES OF AMERICA S. DE R.L. DE C.V.", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 117, Nombre = "UTEXA", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 118, Nombre = "WHA IL VINA", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 119, Nombre = "WILSON GARMENT", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 120, Nombre = "ZABIN INDUSTRIES", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 121, Nombre = "ZHAOQING SHIRFERLY", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Shipper{IdShipper = 122, Nombre = "ZHEJIANG JIAYE", Aereo = false, Maritimo = true, Terrestre = true, FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
            };
            modelBuilder.Entity<Shipper>().HasData(shippers);

            List<Aduana> aduanas = new List<Aduana>
            {
                new Aduana{IdAduana=1,Nombre="ADUANA SANTO TOMAS DE CASTILLA",Abreviatura="ST",Via='M',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=2,Nombre="ADUANA PUERTO QUETZAL",Abreviatura="PQ",Via='M',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=3,Nombre="ADUANA PUERTO BARRIOS",Abreviatura="PB",Via='M',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=4,Nombre="ADUANA TECUN UMAN",Abreviatura="TU",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=5,Nombre="ADUANA EL CARMEN",Abreviatura="EC",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=6,Nombre="ADUANA LA MESILLA",Abreviatura="LM",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=7,Nombre="ADUANA MELCHOR DE MENCOS",Abreviatura="MM",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=8,Nombre="ADUANA EL FLORIDO",Abreviatura="EF",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=9,Nombre="ADUANA DE VEHICULOS",Abreviatura="AV",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=10,Nombre="ADUANA CHAMPERICO",Abreviatura="CH",Via='M',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=11,Nombre="ADUANA PEDRO DE ALVARADO",Abreviatura="PA",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=12,Nombre="ADUANA VALLE NUEVO",Abreviatura="VN",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=13,Nombre="ADUANA SAN CRISTOBAL",Abreviatura="SC",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=14,Nombre="ADUANA AGUA CALIENTE",Abreviatura="AC",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=15,Nombre="ADUANA LA ERMITA",Abreviatura="LE",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=16,Nombre="ADUANA EL CEIBO",Abreviatura="CB",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=17,Nombre="ADUANA SANTA ELENA",Abreviatura="SE",Via='A',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=18,Nombre="ADUANA CENTRAL DE AVIACION",Abreviatura="CA",Via='A',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=19,Nombre="ADUANA EXPRESS AEREO",Abreviatura="EA",Via='A',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=20,Nombre="ADUANA CENTRAL DE GUATEMALA",Abreviatura="CG",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=21,Nombre="ADUANA FARDOS POSTALES",Abreviatura="FP",Via='C',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=22,Nombre="ADUANA PUERTO ACAJUTLA",Abreviatura="S1",Via='M',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=23,Nombre="ADUANA PUERTO DE COTUCO",Abreviatura="S2",Via='M',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=24,Nombre="ADUANA PUERTO CORTES",Abreviatura="H1",Via='M',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=25,Nombre="ADUANA PUERTO CORINTO",Abreviatura="N1",Via='M',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=26,Nombre="ADUANA PEÑAS BLANCAS",Abreviatura="N2",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=27,Nombre="ADUANA ALMACENADORA INTEGRADA",Abreviatura="G1",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=28,Nombre="ADUANA ALMINTER",Abreviatura="G2",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=29,Nombre="ADUANA ALPASA",Abreviatura="G3",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=30,Nombre="ADUANA ALSERSA",Abreviatura="G4",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=31,Nombre="ADUANA CEALSA",Abreviatura="G5",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=32,Nombre="ADUANA ALMAGUATE",Abreviatura="G6",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=33,Nombre="ADUANA ALCORSA",Abreviatura="G7",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=34,Nombre="ADUANA CENTRALSA",Abreviatura="G8",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=35,Nombre="ADUANA INTEGRADA CORINTO",Abreviatura="H6",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=36,Nombre="ADUANA INTEGRADA AGUA CALIENTE",Abreviatura="H7",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Aduana{IdAduana=37,Nombre="ADUANA INTEGRADA EL FLORIDO",Abreviatura="H8",Via='T',FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
            };
            modelBuilder.Entity<Aduana>().HasData(aduanas);

            List<Terminal> terminales = new List<Terminal>{
                new Terminal{IdTerminal = 1, Nombre = "TCQ", Via = 'M', FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Terminal{IdTerminal = 2, Nombre = "TPQ", Via = 'M', FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Terminal{IdTerminal = 3, Nombre = "STC", Via = 'M', FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Terminal{IdTerminal = 4, Nombre = "PB", Via = 'M', FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Terminal{IdTerminal = 5, Nombre = "TEA", Via = 'A', FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Terminal{IdTerminal = 6, Nombre = "TCU", Via = 'A', FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
                new Terminal{IdTerminal = 7, Nombre = "TDL", Via ='A', FechaCreacion = DateTime.Now, IdUsuarioCreacion = 1},
            };
            modelBuilder.Entity<Terminal>().HasData(terminales);

            List<ImportStatus> importStatuses = new List<ImportStatus>
            {
                new ImportStatus{IdImportStatus = 1,Descripcion="Ingreso Inicial",orden=1,Via='M',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus = 2,Descripcion="Entrega de Datos a Digitador",orden=2,Via='M',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus = 3,Descripcion="Elaborar Póliza",orden=3,Via='M',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus = 4,Descripcion="Enviar Póliza a Puerto",orden=4,Via='M',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus = 5,Descripcion="ATC y Aduana",orden=5,Via='M',FechaCreacion= DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus = 6,Descripcion ="Documentos a Transportista",orden=6,Via='M',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus = 7,Descripcion="Llegada a Fábrica",orden=7,Via='M',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus = 8,Descripcion="Salida de Fábrica",orden=8,Via='M',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus = 9,Descripcion="Finalizado",orden=9,Via='M',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},

                new ImportStatus{IdImportStatus =10,Descripcion="Ingreso Inicial",orden=1,Via='A',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus = 11,Descripcion="Entrega de Datos a Digitador",orden=2,Via='A',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus =12,Descripcion="Elaborar Póliza",orden=3,Via='A',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus =13,Descripcion="Enviar Póliza Aeropuerto",orden=4,Via='A',FechaCreacion= DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus =14,Descripcion="Llegada a Fabrica",orden=5,Via='A',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus =15,Descripcion="Finalizado",orden=6,Via='A',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},

                new ImportStatus{IdImportStatus =16,Descripcion="Ingreso Inicial",orden=1,Via='T',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus = 17,Descripcion="Entrega de Datos a Digitador",orden=2,Via='T',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus =18,Descripcion="Elaborar Póliza",orden=3,Via='T',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus =19,Descripcion="Enviar Póliza",orden=4,Via='T',FechaCreacion= DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus =20,Descripcion="Llegada a Almacenadora",orden=5,Via='T',FechaCreacion= DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus =21,Descripcion="Llegada a Fabrica",orden=6,Via='T',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus =22,Descripcion="Finalizado",orden=7,Via='T',FechaCreacion=DateTime.Now,IdUsuarioCreacion=1},

                new ImportStatus{IdImportStatus = 23,Descripcion="Cambio ETA",orden = 0,Via = 'O', FechaCreacion= DateTime.Now,IdUsuarioCreacion=1},
                new ImportStatus{IdImportStatus = 24,Descripcion="Cambio Destino",orden = 0,Via = 'O', FechaCreacion= DateTime.Now,IdUsuarioCreacion=1},
            };
            modelBuilder.Entity<ImportStatus>().HasData(importStatuses);
        }
    }
}
