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

        

        protected void btnEditarC_Click(object sender, EventArgs e)
        {

            ClienteController ctrl = new ClienteController();
            Cliente c = new Cliente();
            c.Nome = txtNomeC.Text;
            c = ctrl.BuscarCliente(c.Nome);

            if(c != null)
            {
                txtEdtCliente.Text = c.Nome;
                ctrl.Editar(c);
            }
            
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            
            Cliente c = new Cliente();
            ClienteController ct = new ClienteController();
            c.Nome = txtExcCliente.Text;
            c = ct.BuscarCliente(c.Nome);
            

            if(c != null)
            {
                txtExcCliente.Text = c.Nome;
                ct.Excluir(c);

            }
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            ClienteController ctrl = new ClienteController();
            Cliente c = new Cliente();
            c.Nome = txtNomeC.Text;
            
            if(c != null)
            {
                txtNomeC.Text = c.Nome;
                c = ctrl.BuscarCliente(c.Nome);


            }
        }
    }
}