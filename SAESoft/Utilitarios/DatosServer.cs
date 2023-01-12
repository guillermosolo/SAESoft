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
            using (DB_Context _Contexto = new DB_Context())
            {
              fecha = _Contexto.Database.SqlQuery<DateTime>($"SELECT GETDATE() AS [Value]").First();
          
            }
            return fecha;
        }

        public static Boolean ConectarFileServer(string path)
        {
            using (UNCAccessWithCredentials unc = new UNCAccessWithCredentials())
            {
                if (!unc.NetUseWithCredentials(path, "saesoft", "", "$@3$oft2023"))
                {
                    return false;
                } else
                {
                    return true;
                }
            }
        }
    }
}
