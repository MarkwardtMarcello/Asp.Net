using Estacionamento.Controller;
using Estacionamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estacionamento.Views
{
    public partial class CadastCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }
       

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteController ctrl = new ClienteController();
            Cliente c = new Cliente();
            c.Nome = txtNomeC.Text;
            
                    
            ctrl.Adicionar(c);
            txtNomeC.Text = "";
            

        }

        
        
    }
}