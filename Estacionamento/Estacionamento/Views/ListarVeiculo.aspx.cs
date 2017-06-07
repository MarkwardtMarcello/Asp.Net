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
    public partial class ListarVeiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            VeiculoController ctrl = new VeiculoController();
            List<Veiculo> lista = ctrl.Listar();

            gvListarV.DataSource = lista;
            gvListarV.DataBind();

       

        }

        protected void linkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastVeiculo.aspx");
        }
    }
}