<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastVeiculo.aspx.cs" Inherits="Estacionamento.Views.CadastVeiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

    <h1>Cadastrar Veiculo</h1>

    
    <asp:Label ID="lblNomeV" runat="server" Text="Nome: "></asp:Label>
    <asp:TextBox ID="txtNomeV" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblVcor" runat="server" Text="Cor: "></asp:Label>
    <asp:TextBox ID="txtVCor" runat="server"></asp:TextBox>
    <br/>
    
    <asp:Label ID="lblNomeCliente" runat="server" Text="Cliente: "></asp:Label>
    <asp:DropDownList ID="dropdwClietV" runat="server" DataTextField="Nome" DataValueField="Id" DataSourceID="SqlDataSource1" Height="16px" Width="129px"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BancoEstarContainer %>" SelectCommand="SELECT [Id], [Nome] FROM [Clientes]"></asp:SqlDataSource>
    <br />

    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click"   />
    

            </ContentTemplate>
        </asp:UpdatePanel>
    

</asp:Content>
