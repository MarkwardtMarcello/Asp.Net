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
    public partial class Cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
            {
            Ferramenta ferra = new Ferramenta();
            ferra.Nome = txtNomeFerramenta.Text;
            ferra.Diametro = txtDiamFerra.Text;
            ferra.Status = txtStatusFerra.Text;
            ferra.Producao = txtProdFerra.Text;

            FerramentaController ctrl = new FerramentaController();
            ctrl.Adicionar(ferra);


        }
    }
}