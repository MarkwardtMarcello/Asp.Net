<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarVeiculo.aspx.cs" Inherits="Estacionamento.Views.ListarVeiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

    <asp:GridView ID="gvListarV" runat="server"></asp:GridView>
    <br />

    <asp:LinkButton ID="linkVoltar" runat="server" OnClick="linkVoltar_Click">Voltar</asp:LinkButton>

            </ContentTemplate>
         </asp:UpdatePanel>

</asp:Content>
