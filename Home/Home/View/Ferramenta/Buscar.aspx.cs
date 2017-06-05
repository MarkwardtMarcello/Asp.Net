using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Home.Model;
using Home.Controller;

namespace Home.View
{
    public partial class Buscar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Ferramenta f = new Ferramenta();
            f.Nome = txtBuscaNome.Text.ToString();
            f.Diametro = txtDiamFerra.Text;
            f.Status = txtStatusFerra.Text;
            f.Producao = txtProdFerra.Text;
            

            FerramentaController ctrl = new FerramentaController();
            ctrl.BuscarFerramentaNome(f);
        }
    }
}