<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Resultado.aspx.cs" Inherits="Calculos.Resultado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

          if(!IsPostBack)
            {
                if (Session["valor1"] != null && Session["valor2"] != null)
                {
                    // recuperar valores da session
                    double valor1 = Convert.ToDouble(Session["valor1"]);
                    double valor2 = Convert.ToDouble(Session["valor2"]);

                    // efetuar calculos
                    double soma = valor1 + valor2;
                    double subt = valor1 - valor2;
                    double mult = valor1 * valor2;
                    double div = valor1 / valor2;


                    // preencher campos (exibir valores)
                    txtV1A.Text = valor1.ToString();
                    txtV2A.Text = valor2.ToString();
                    txtR1A.Text = soma.ToString();

                    txtV1S.Text = valor1.ToString();
                    txtV2S.Text = valor2.ToString();
                    txtR1S.Text = subt.ToString();

                    txtV1M.Text = valor1.ToString();
                    txtV2M.Text = valor2.ToString();
                    txtR1M.Text = mult.ToString();
                    
                    txtV1D.Text = valor1.ToString();
                    txtV2D.Text = valor2.ToString();
                    txtR1D.Text = div.ToString();
                }
                else
                {
                    Response.Redirect("~/Calcular.aspx");
                }

            }





</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
