﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastCliente.aspx.cs" Inherits="Estacionamento.Views.CadastCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

    <h1>Cadastrar Cliente/Buscar Cliente</h1>

    <asp:Label ID="lblNomeC" runat="server" Text="Nome: "></asp:Label>
    
    <asp:TextBox ID="txtNomeC" runat="server"></asp:TextBox>
    
    <br />

    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click"   />
    
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
    
            <h1>Cliente Encontrado</h1>
            <asp:Label ID="lblBNome" runat="server" Text="Nome: "></asp:Label>
    
    <asp:TextBox ID="txtBNome" runat="server"></asp:TextBox>


    <h1>Editar Cliente</h1>

    <asp:Label ID="lblEditCliente" runat="server" Text="Editar Cliente: "></asp:Label>
    
    <asp:TextBox ID="txtEdtCliente" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnEditarC" runat="server" Text="Editar" OnClick="btnEditarC_Click" />


    <h1>Excluir Cliente</h1>

    <asp:Label ID="lblExcCliente" runat="server" Text="Excluir Cliente: "></asp:Label>
    
    <asp:TextBox ID="txtExcCliente" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />

    
   
</ContentTemplate>
            </asp:UpdatePanel>

</asp:Content>
