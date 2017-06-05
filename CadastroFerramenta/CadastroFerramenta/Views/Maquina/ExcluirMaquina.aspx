<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExcluirMaquina.aspx.cs" Inherits="CadastroFerramenta.Views.Maquina.ExcluirMaquina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Excluir Maquina</h1>
    <asp:GridView ID="gvExcluir" runat="server"></asp:GridView>

    <br/>

    <h2>Excluir Maquina</h2>
    <br />
    <asp:Label ID="lblNomeM" runat="server" Text="Nome: "></asp:Label>
    <asp:TextBox ID="txtNomeM" runat="server"></asp:TextBox><br /><br />
    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />

</asp:Content>
