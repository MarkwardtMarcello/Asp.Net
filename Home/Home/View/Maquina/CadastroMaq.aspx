<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroMaq.aspx.cs" Inherits="Home.View.Maquina.CadastroMaq" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Cadastrar Maquina</h1>
    <asp:Label ID="lbl" runat="server" Text="Nome: "></asp:Label>
    <asp:TextBox ID="txtNomeMaq" runat="server"></asp:TextBox></br>
    <asp:Label ID="lblProduto" runat="server" Text="Fabricação do Produto: "></asp:Label>
    <asp:TextBox ID="txtProduto" runat="server"></asp:TextBox></br>
    </br></br>
    <asp:Button ID="btnSalvarMaq" runat="server" Text="Salvar" OnClick="btnSalvarMaq_Click" />
</asp:Content>
