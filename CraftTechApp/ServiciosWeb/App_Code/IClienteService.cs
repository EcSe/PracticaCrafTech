using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Entidades;
using CapaNegocio;
using System.Data;
// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IClienteService" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IClienteService
{
    [OperationContract]
    DataSet Listar();

    [OperationContract]
    DataSet Buscar(int codigo);

    [OperationContract]
    List<String> Agregar(ClienteEntidad cli);

    [OperationContract]
    List<String> Eliminar(int codigo);
}
