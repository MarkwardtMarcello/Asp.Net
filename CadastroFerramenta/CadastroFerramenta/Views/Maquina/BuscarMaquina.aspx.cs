using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CadastroFerramenta.Controller;
using CadastroFerramenta.Model;

namespace CadastroFerramenta.Views.Maquina
{
    public partial class BuscarMaquina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscarM_Click(object sender, EventArgs e)
        {
            //Model.Maquina m = new Model.Maquina();
            Maquina m = new Maquina();
            m.Nome = txtNomeM.Text;
            MaquinaController ctrl = new MaquinaController();
            ctrl.BuscarMaquinaNome(m);

            if (ctrl.BuscarMaquinaNome(m) != null)
            {
                m.Produto = txtProdM.Text;

            }
        }
    }
}