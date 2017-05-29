<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Criar.aspx.cs" Inherits="Aula2405_EF_MF_MODELFIRST.VIEWS.Categorias.Criar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h1>Criar Categoria</h1>
    <asp:Label ID="lblNome" runat="server" Text="Nome: "></asp:Label>  
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    </br>
    <asp:Label ID="lblDescricao" runat="server" Text="Descrição: "></asp:Label>
    <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
    </br></br>

    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />



</asp:Content>
