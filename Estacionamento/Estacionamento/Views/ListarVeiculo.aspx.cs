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
    public partial class ListarVeiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            VeiculoController ctrl = new VeiculoController();
            List<Veiculo> lista = ctrl.Listar();

            gvListarV.DataSource = lista;
            gvListarV.DataBind();

       

        }

        protected void linkVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastVeiculo.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            VeiculoController ctrl = new VeiculoController();
            Veiculo v = new Veiculo();
            v.Modelo = txtBV.Text;
            v.Cor = txtBVC.Text;
            //v = ctrl.BuscarVeiculo(v.Modelo);

            if (v != null)
            {
                txtBV.Text = v.Modelo;
                txtBVC.Text = v.Cor;
                txtEditVCor.Text = v.Modelo;
                txtEdtV.Text = v.Cor;
                txtExcv.Text = v.Modelo;
                txtExVcor.Text = v.Cor;
                ctrl.BuscarVeiculo(v.Modelo);

            }
        }

        protected void btnEditarV_Click(object sender, EventArgs e)
        {
            VeiculoController ctrl = new VeiculoController();
            Veiculo v = new Veiculo();
            v.Modelo = txtEdtV.Text;
            v.Cor = txtEditVCor.Text;
            if (v != null)
            {
                txtEdtV.Text = v.Modelo;
                txtEditVCor.Text = v.Cor;
                ctrl.Editar(v);

            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Veiculo v = new Veiculo();
            VeiculoController ctrl = new VeiculoController();
            v.Modelo = txtExcv.Text;
            v.Cor = txtExVcor.Text;

            v = ctrl.BuscarVeiculo(v.Modelo);

            if (v != null)
            {
                txtExcv.Text = v.Modelo;
                txtExVcor.Text = v.Cor;
                ctrl.Excluir(v);
            }
        }
    }
}