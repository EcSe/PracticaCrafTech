using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using Entidades;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class ClienteDAO
    {
        SqlConnection con = Conexion.ConectarBD();

        private String mensaje;
        public String Mensaje { get {return mensaje;}}

        public void ListarDatagrid(DataGrid dgv)
        {
            SqlCommand cmd = new SqlCommand("spListarCliente", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dgv.DataSource = dt;
        }


        public DataSet Listar()
        {
            SqlCommand cmd = new SqlCommand("spListarCliente", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public DataSet Buscar(int CodCliente)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spBuscarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodCliente", CodCliente);
               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                da.Fill(dt);
                return dt;
          
            }
            catch (Exception)
            {
                
                throw;
            }
        }


        public bool Agregar(ClienteEntidad cliente)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("spAgregarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                cmd.Parameters.AddWithValue("@TipoDocumento", cliente.TipoDocumento);
                cmd.Parameters.AddWithValue("@NroDocumento", cliente.NroDocumento);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@Provincia", cliente.Provincia);
                cmd.Parameters.AddWithValue("@Ciudad", cliente.Ciudad);
                cmd.Parameters.AddWithValue("@Distrito", cliente.Distrito);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@Usuario", cliente.Usuario);
                cmd.Parameters.AddWithValue("@Contrasena", cliente.Contrasena);
                cmd.Parameters.AddWithValue("@RazonSocial", cliente.RazonSocial);
                cmd.Parameters.AddWithValue("@RUC", cliente.RUC);
                cmd.Parameters.AddWithValue("@FechaNac", cliente.FechaNac);
                cmd.Parameters.AddWithValue("@EstadoCivil", cliente.EstadoCivil);
                cmd.Parameters.AddWithValue("@Ocupacion", cliente.Ocupacion);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@CodPais", cliente.pais.CodPais);

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

        public bool Eliminar(int CodCliente)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spEliminarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodCliente",CodCliente);

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
                
                mensaje = "Error: "+ ex.Message;
                return false;
            }
        }

    }
}
