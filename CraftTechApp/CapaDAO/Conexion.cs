using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        public static SqlConnection ConectarBD()
        {
         String cadena = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
           SqlConnection conexion = new SqlConnection(cadena);
           return conexion;
        }

    }
}
