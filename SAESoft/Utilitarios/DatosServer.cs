using Microsoft.EntityFrameworkCore;
using SAESoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
