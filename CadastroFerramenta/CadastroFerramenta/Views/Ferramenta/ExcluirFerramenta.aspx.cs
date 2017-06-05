using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CadastroFerramenta.Controller;
using CadastroFerramenta.Model;

namespace CadastroFerramenta.Views.Ferramenta
{
    public partial class ExcluirFerramenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Ferramenta f = new Ferramenta();
            f.Nome = txtNomeFer.Text;
            FerramentaController ctrl = new FerramentaController();
            f = ctrl.BuscarFerramentaNome(f);
            if (ctrl.BuscarFerramentaNome(f) != null)
            {
                ctrl.Excluir(f);

            }
        }
    }
}