using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using Entidades;

namespace CapaNegocio
{
    public class ProductoDAO
    {
        
        SqlConnection con = Conexion.ConectarBD();
        
        public DataSet Listar()
        {
            SqlCommand cmd = new SqlCommand("spcListarProducto",con );
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
