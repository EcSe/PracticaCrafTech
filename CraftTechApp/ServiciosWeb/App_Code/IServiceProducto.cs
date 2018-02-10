using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;
using CapaNegocio;
using Entidades;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceProducto" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IServiceProducto
{
    [OperationContract]
    DataSet Listar();

    [OperationContract]
    List<String> Agregar(ProductoEntidad prod);
}
