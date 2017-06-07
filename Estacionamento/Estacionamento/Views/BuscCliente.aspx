<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuscCliente.aspx.cs" Inherits="Estacionamento.Views.BuscCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Buscar Cliente</h1>

    <asp:Label ID="lblBuscaC" runat="server" Text="Nome do Cliente:  "></asp:Label>

    <asp:TextBox ID="txtBuscaN" runat="server"></asp:TextBox>
    <br/>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
    <br/><br/>

    <asp:TextBox ID="txtEncont" runat="server"></asp:TextBox>

</asp:Content>
