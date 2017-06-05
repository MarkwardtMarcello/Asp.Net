using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Home.Controller;
using Home.Model;

namespace Home.View
{
    public partial class ListarFerramentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           FerramentaController ctrl = new FerramentaController();
           List<Ferramenta> lista = ctrl.Listar();
           gvListaFerramenta.DataSource = lista.OrderBy(c => c.Nome);
        }
    }
}