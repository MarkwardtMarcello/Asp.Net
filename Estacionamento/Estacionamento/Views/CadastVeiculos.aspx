<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastVeiculos.aspx.cs" Inherits="Estacionamento.Views.CadastVeiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Cadastrar Veiculos</h1>

    <asp:Label ID="lblModelo" runat="server" Text="Modelo:  "></asp:Label>
    <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
    <br />
    
    <asp:Label ID="lblCorV" runat="server" Text="Cor:  "></asp:Label>
    <asp:TextBox ID="txtCor" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />

    <h1>Buscara Veiculos</h1><br /><br />
    <asp:Label ID="txtBuscVeic" runat="server" Text="Buscar:  "></asp:Label>
    <asp:TextBox ID="txtModBusca" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />


    <h1>Editar Veiculos</h1><br /><br />

    <asp:Label ID="lblEditarV" runat="server" Text="Editar:  "></asp:Label>
    <asp:TextBox ID="txtEditV" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="btnEditarV" runat="server" Text="Salvar Alteração" OnClick="btnEditarV_Click" />

    <h1>Excluir Veiculos</h1><br /><br />

    <asp:Label ID="lblExcV" runat="server" Text="Excluir:  "></asp:Label>
    <asp:TextBox ID="txtExcluirV" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="btnExcluirV" runat="server" Text="Excluir" OnClick="btnExcluirV_Click" />



    <h1>Listar Veiculos</h1><br /><br />

    <asp:GridView ID="gvListarV" runat="server"></asp:GridView>


</asp:Content>
