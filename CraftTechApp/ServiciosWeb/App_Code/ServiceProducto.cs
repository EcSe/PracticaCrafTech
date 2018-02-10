using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using CapaNegocio;
using Entidades;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "ServiceProducto" en el código, en svc y en el archivo de configuración a la vez.
public class ServiceProducto : IServiceProducto
{
    ProductoDAO prodDAO = new ProductoDAO();

    public System.Data.DataSet Listar()
    {
        return prodDAO.Listar();
    }

    public List<string> Agregar(Entidades.ProductoEntidad prod)
    {
        List<String> Resultados = new List<string>();

        String Estado = Convert.ToString(prodDAO.Agregar(prod));
        String Mensaje = prodDAO.Mensaje;
        Resultados.Add(Estado);
        Resultados.Add(Mensaje);
        return Resultados;
    }
}
