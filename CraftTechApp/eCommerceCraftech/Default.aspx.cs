using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Entidades;

public partial class _Default : System.Web.UI.Page
{
    ServiceCliente.ClienteServiceClient cliservice = new ServiceCliente.ClienteServiceClient();
    void Listar()
    {
       gvdatos.DataSource= cliservice.Listar();
       gvdatos.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Listar();
        }
    }
}