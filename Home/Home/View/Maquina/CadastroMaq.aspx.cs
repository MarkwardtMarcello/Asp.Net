
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
    public partial class CadastroMaq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvarMaq_Click(object sender, EventArgs e)
        {
            Maquina maq = new Maquina();
            maq.Nome = txtNomeMaq.Text;
            maq.Produto = txtProduto.Text;

            MaquinaController ctrl = new MaquinaController();
            ctrl.Adicionar(maq);


        }
    }
}