<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProdutos.aspx.cs" Inherits="Aula2405_EF_MF_MODELFIRST.VIEWS.Produtos.ListaProdutos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h1>Produtos Ativos</h1>
    <asp:GridView ID="gvProdutos" runat="server"></asp:GridView>

     <h1>Produtos Excluidas</h1>
    <asp:GridView ID="gvProdutosExcluidas" runat="server"></asp:GridView>


</asp:Content>
