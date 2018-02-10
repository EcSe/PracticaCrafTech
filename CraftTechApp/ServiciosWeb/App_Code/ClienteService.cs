using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Entidades;
using CapaNegocio;
using System.Data;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "ClienteService" en el código, en svc y en el archivo de configuración a la vez.
public class ClienteService : IClienteService
{
    private ClienteDAO cliDAO = new ClienteDAO();

    public System.Data.DataSet Listar()
    {
        return cliDAO.Listar();
    }


    public List<string> Agregar(Entidades.ClienteEntidad cli)
    {
        List<String> Resultado = new List<string>();
        String Estado = Convert.ToString(cliDAO.Agregar(cli));
        String Mensaje = cliDAO.Mensaje;

        Resultado.Add(Estado);
        Resultado.Add(Mensaje);
        return Resultado;
     }

    public List<string> Eliminar(int codigo)
    {
        List<String> Resultado = new List<string>();
        String Estado = Convert.ToString(cliDAO.Eliminar(codigo));
        String Mensaje = cliDAO.Mensaje;

        Resultado.Add(Estado);
        Resultado.Add(Mensaje);
        return Resultado;
    }


    public DataSet Buscar(int codigo)
    {

        return cliDAO.Buscar(codigo);
    }
}
