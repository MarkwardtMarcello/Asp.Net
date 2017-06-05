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
    public partial class EditarFerramenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            FerramentaController ctrl = new FerramentaController();
            Ferramenta f = new Ferramenta();
            f.Nome = txtNomeFerramenta.Text;
            f = ctrl.BuscarFerramentaNome(f);

            if (ctrl.BuscarFerramentaNome(f) != null)
            {
                txtNomeFerramenta.Text = f.Nome;
                txtDiamFerra.Text = f.Diametro;
                txtStatusFerra.Text = f.Status;
                txtProdFerra.Text = f.Producao;
                ctrl.Editar(f);
            }
        }
    }
}