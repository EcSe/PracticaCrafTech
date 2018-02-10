using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaNegocio;
using Entidades;

public partial class Default2 : System.Web.UI.Page
{
    ClienteDAO cliDAO = new ClienteDAO();

    void Listar()
    {
        gvCliente.DataSource = cliDAO.Listar();
        gvCliente.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Listar();
    }
}