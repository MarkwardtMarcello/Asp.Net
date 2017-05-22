using Aula2205.DAL_CamadaDeAcessoaDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2205.Views.Categoria
{
    public partial class ListaCategorias : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //contexto (referencia para o banco)
            strConnLojaEntities contexto = new strConnLojaEntities();

            gvCategorias.DataSource = contexto.Categoria.ToList(); //transformar a tabela em lista.
            gvCategorias.DataBind();//processar e montar a tabela
        }
    }
}