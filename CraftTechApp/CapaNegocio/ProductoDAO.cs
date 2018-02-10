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
        private String mensaje;
        public String Mensaje { get { return mensaje; } }
        
        SqlConnection con = Conexion.ConectarBD();
         public DataSet Listar()
        {
            SqlCommand cmd = new SqlCommand("spListarProducto",con );
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public bool Agregar(ProductoEntidad prod)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("spAgregarProducto", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodProducto", prod.CodProducto);
                cmd.Parameters.AddWithValue("@Nombre", prod.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", prod.Descripcion);
                cmd.Parameters.AddWithValue("@Especificacion", prod.Especificacion);
                cmd.Parameters.AddWithValue("@Peso", prod.Peso);
                cmd.Parameters.AddWithValue("@Longitud", prod.Longitud);
                cmd.Parameters.AddWithValue("@Alto", prod.Alto);
                cmd.Parameters.AddWithValue("@Ancho", prod.Ancho);
                cmd.Parameters.AddWithValue("@Diametro", prod.Diametro);
                cmd.Parameters.AddWithValue("@Precio", prod.Precio);
                cmd.Parameters.AddWithValue("@CodSubCategoria", prod.SubCategoria.CodSubCategoria);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow fila = dt.Rows[0];

                byte i = Convert.ToByte(fila["CodError"]);
                mensaje = fila["Mensaje"].ToString();
                if (i == 1) return true;
                else return false;

            }
            catch (Exception ex)
            {

                mensaje = "Error: " + ex.Message;
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
