using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Home.Controller;
using Home.Model;

namespace Home.View.Maquina
{
    public partial class ListarMaq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MaquinaController ctrl = new MaquinaController();
             List<Maquina> lista = ctrl.Listar();
             gvLista.DataSource = lista.OrderBy(c => c.Nome);

        }
    }
}