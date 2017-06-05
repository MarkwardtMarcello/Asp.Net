<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Excluir.aspx.cs" Inherits="Home.View.Excluir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Excluir Ferramentas</h1>
    <asp:GridView ID="gvExcluir" runat="server"></asp:GridView>
    <h2>Escolher Ferramenta para exclusão</h2>
    <asp:Label ID="lblNome" runat="server" Text="Nome: "></asp:Label>
    <asp:TextBox ID="txtNomeFer" runat="server"></asp:TextBox>
    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />

</asp:Content>
