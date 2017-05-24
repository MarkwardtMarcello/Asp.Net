<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastrarCategoria.aspx.cs" Inherits="Aula2405_EF_Modelo_Base.Views.Categorias.CadastrarCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Label ID="lblNomeCat" runat="server" Text="Nome da Categoria: "></asp:Label>
    <asp:TextBox ID="txtNomeCat" runat="server"></asp:TextBox>
    <br/>
    <asp:Label ID="lblDescricaoCat" runat="server" Text="Descrição do Produto: "></asp:Label>
    <asp:TextBox ID="txtDescricaCat" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br/>
    <asp:Button ID="btnSalvarCat" runat="server" Text="Salvar" OnClick="btnSalvarCat_Click" />
    <asp:Button ID="btbCancelar" runat="server" Text="Cancelar" />
</asp:Content>
