<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarMaquina.aspx.cs" Inherits="CadastroFerramenta.Views.Maquina.EditarMaquina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Editar Maquinas</h1>

    <asp:GridView ID="gvEditarM" runat="server"></asp:GridView>

    <h2>Editar: </h2>

    <asp:Label ID="lblNomeM" runat="server" Text="Nome: "></asp:Label>
    <asp:TextBox ID="txtNomeM" runat="server"></asp:TextBox>
    <br/>

    <asp:Label ID="lblProd" runat="server" Text="Produto: "></asp:Label>
    <asp:TextBox ID="txtProd" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />

</asp:Content>
