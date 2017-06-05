<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarFerramenta.aspx.cs" Inherits="CadastroFerramenta.Views.Ferramenta.EditarFerramenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Editar Ferramentas</h1>
    
    <h2>Ferramentas Cadastradas</h2>
    <asp:GridView ID="gvEditFer" runat="server"></asp:GridView>
    
    <br/>
    <h2>Editar a Ferramenta: </h2>
    <asp:Label ID="lblNomeFerramenta" runat="server" Text="Nome da ferramenta: "></asp:Label>
    <asp:TextBox ID="txtNomeFerramenta" runat="server"></asp:TextBox>
    <br/><br/>
    <asp:Label ID="lblDiamentroFerramenta" runat="server" Text="Diametro da Ferramenta: "></asp:Label>
    <asp:TextBox ID="txtDiamFerra" runat="server"></asp:TextBox>
    <asp:Label ID="lblDiam" runat="server" Text="mm"></asp:Label>
    <br/><br/>
    <asp:Label ID="lblStatusFerramenta" runat="server" Text="Status da Ferramenta: "></asp:Label>
    <asp:TextBox ID="txtStatusFerra" runat="server"></asp:TextBox>
    <br/><br/>
    <asp:Label ID="lblProducaoFerramenta" runat="server" Text="Produção Total da Ferramenta: "></asp:Label>
    <asp:TextBox ID="txtProdFerra" runat="server"></asp:TextBox>
    <asp:Label ID="lblToneladas" runat="server" Text="toneladas"></asp:Label>
    <br/><br/>
    <asp:Button ID="btnEditar" runat="server" Text="Salvar" OnClick="btnEditar_Click" />
    <asp:RegularExpressionValidator ID="revMensagem" runat="server" ErrorMessage="Ferramenta  Editada!" EnableViewState="False" Visible="True"></asp:RegularExpressionValidator>

</asp:Content>
