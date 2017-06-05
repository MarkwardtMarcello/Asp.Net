using Home.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Home.View.Maquina
{
    public partial class ExcluirMaq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Maquina m = new Maquina();
            MaquinaController ctrl = new MaquinaController();
            m.Nome = txtNomeM.Text;
            m = ctrl.Excluir(m);
            if(ctrl.Excluir(m) != null)
            {
                ctrl.Excluir(m);
            }
        }
    }
}