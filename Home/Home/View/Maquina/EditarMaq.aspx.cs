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
    public partial class EditarMaq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            MaquinaController ctrl = new MaquinaController();
            Maquina m = new Maquina();
            m.Nome = txtNomeM.Text;
            m = ctrl.BuscarMaquinaNome(m);

            if(ctrl.BuscarMaquinaNome(m)!= null)
            {
                txtNomeM.Text = m.Nome;
                txtProd.Text = m.Produto;
                ctrl.Editar(m);
            }

        }
    }
}