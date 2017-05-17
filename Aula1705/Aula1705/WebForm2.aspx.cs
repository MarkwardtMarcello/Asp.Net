using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1705
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int qtdCliquesViewState = Convert.ToInt32(ViewState["qtdCliques"]);
            int qntCliquesSession = Convert.ToInt32(Session["QntCliquesSession"]);

            lblQuatidadesCliques.Text = qntCliquesSession.ToString();


        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1");
        }
    }
}