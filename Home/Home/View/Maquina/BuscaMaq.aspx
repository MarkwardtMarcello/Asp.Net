<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuscaMaq.aspx.cs" Inherits="Home.View.Maquina.BuscaMaq" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Buscar Maquinas</h1>

    <asp:Label ID="lblNomeM" runat="server" Text="Nome: "></asp:Label>
        <asp:TextBox ID="txtNomeM" runat="server"></asp:TextBox>
     <asp:Label ID="lblProdM" runat="server" Text="Produto: "></asp:Label>
    <asp:TextBox ID="txtProdM" runat="server"></asp:TextBox>
    <br/>
    <asp:Button ID="btnBuscarM" runat="server" Text="Buscar" OnClick="btnBuscarM_Click" /><br/>
   




</asp:Content>
