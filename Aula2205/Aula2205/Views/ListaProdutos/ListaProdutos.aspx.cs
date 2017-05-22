using Aula2205.DAL_CamadaDeAcessoaDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2205.Views.ListaProdutos
{
    public partial class ListaProdutos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            strConnLojaEntities contextoProduto = new strConnLojaEntities();

            gdvProdutos.DataSource = contextoProduto.Produto.ToList(); //transformar a tabela em lista.
            gdvProdutos.DataBind();//processar e montar a tabela

        }
    }
}