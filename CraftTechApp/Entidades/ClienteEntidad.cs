using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace Entidades
{
    public class ClienteEntidad
    {
        public int CodCliente { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Sexo { get; set; }
        public String TipoDocumento { get; set; }
        public String NroDocumento { get; set; }
        public String Email { get; set; }
        public String Provincia { get; set; }
        public String Ciudad { get; set; }
        public String Distrito { get; set; }
        public String Direccion { get; set; }
        public String Usuario { get; set; }
        public String Contrasena { get; set; }
        public String RazonSocial { get; set; }
        public String RUC { get; set; }
        public DateTime FechaNac { get; set; }
        public String EstadoCivil { get; set; }
        public String Ocupacion { get; set; }
        public String Telefono { get; set; }
        public PaisEntidad pais { get; set; }
    }
}
