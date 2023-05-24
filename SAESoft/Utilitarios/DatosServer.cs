using ConnectUNCWithCredentials;
using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAESoft.Utilitarios
{
    public static class DatosServer
    {
        public static DateTime FechaServer()
        {
            DateTime fecha;
            using (SAESoftContext db = new())
            {
              fecha = db.Database.SqlQuery<DateTime>($"SELECT GETDATE() AS [Value]").First();
          
            }
            return fecha;
        }

        public static Boolean ConectarFileServer(string path)
        {
            using UNCAccessWithCredentials unc = new();
            if (!unc.NetUseWithCredentials(path, "saesoft", "", "$@3$oft2023"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static String NombreUsuario(int? id)
        {
            string nombre;
            using (SAESoftContext db = new())
            {
                var u = db.Usuarios.FirstOrDefault(u=>u.IdUsuario == id);
                nombre = u.Nombres + " " + u.Apellidos;
            }
            return nombre;
        }
    }
}
