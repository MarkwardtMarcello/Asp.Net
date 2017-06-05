<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="Home.View.Cadastrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Cadastrar Ferramenta</h1>
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
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click"/>
    


</asp:Content>
