using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace CapaNegocio
{
    public class Conexion
    {
        public String CadenaConexion { get; set; }

        public Conexion()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        }
    }
}
