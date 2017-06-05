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
    public partial class BuscaMaq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarM_Click(object sender, EventArgs e)
        {
            Maquina m = new Maquina();
            m.Nome = txtNomeM.Text;
            MaquinaController ctrl = new MaquinaController();
            ctrl.BuscarMaquinaNome(m);

            if(ctrl.BuscarMaquinaNome(m) != null)
            {
                m.Produto.Text = txtProdM;

            }
            

        }
    }
}