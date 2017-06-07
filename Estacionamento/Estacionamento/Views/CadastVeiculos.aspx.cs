using Estacionamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Estacionamento.Controller;

namespace Estacionamento.Views
{
    public partial class CadastVeiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Veiculo v = new Veiculo();
            v.Modelo = txtModelo.Text;
            v.Cor = txtCor.Text;
            VeiculoController ctrl = new VeiculoController();
            ctrl.Adicionar(v);

            

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Veiculo v = new Veiculo();
            v.Modelo = txtModelo.Text;

            VeiculoController busca = new VeiculoController();
            if(busca.BuscarVeiculo(v) != null)
            {

                busca.BuscarVeiculo(v);
//                txtBuscVeic.Text = ;

            }



        }

        protected void btnEditarV_Click(object sender, EventArgs e)
        {

        }

        protected void btnExcluirV_Click(object sender, EventArgs e)
        {

        }
    }
}