<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastCliente.aspx.cs" Inherits="Estacionamento.Views.CadastCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

    <h1>Cadastrar Cliente/Buscar Cliente</h1>

    <asp:Label ID="lblNomeC" runat="server" Text="Nome: "></asp:Label>
    
    <asp:TextBox ID="txtNomeC" runat="server"></asp:TextBox>
    
    <br />

    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click"   />
    
    

    
   
</ContentTemplate>
            </asp:UpdatePanel>

</asp:Content>
