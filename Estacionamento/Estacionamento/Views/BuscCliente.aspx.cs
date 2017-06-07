using Estacionamento.Controller;
using Estacionamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estacionamento.Views
{
    public partial class BuscCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Nome = txtBuscaN.Text;

            ClienteController ctrl = new ClienteController();

            if (ctrl.BuscarCliente(c) != null)
            {
                ctrl.BuscarCliente(c);
                txtEncont.Text = ctrl.BuscarCliente(c).ToString();
            }
                

        }
    }
}