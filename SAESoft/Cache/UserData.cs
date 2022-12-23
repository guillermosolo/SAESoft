using SAESoft.Models;
using SAESoft.Models.AdministracionSistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAESoft.Cache
{
    public static class UserData
    {
        public static Usuario? usuarioLogged { get; set; }

        public static Boolean hasPermission(string permiso)
        {
            using (DB_Context _Contexto = new DB_Context())
            {
                return usuarioLogged.Rol.Permisos.FirstOrDefault(p => p.Nombre == permiso) != null;
            }
        }

        public static Boolean hasRole(int idRol)
        {
            using (DB_Context _Contexto = new DB_Context())
            {
                return usuarioLogged.Rol.IdRol == idRol;
            }
        }
    }
}
