<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuscaFerramenta.aspx.cs" Inherits="CadastroFerramenta.Views.Ferramenta.BuscaFerramenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Buscar Ferramenta</h1>
    <asp:Label ID="lblBuscaNome" runat="server" Text="Buscar por nome: "></asp:Label></br>
    <asp:TextBox ID="txtBuscaNome" runat="server"></asp:TextBox></br>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />

    <h2>Resultado: </h2>
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

</asp:Content>
