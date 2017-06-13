<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarVeiculo.aspx.cs" Inherits="Estacionamento.Views.ListarVeiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

    <asp:GridView ID="gvListarV" runat="server"></asp:GridView>
    <br />

    <asp:LinkButton ID="linkVoltar" runat="server" OnClick="linkVoltar_Click">Voltar</asp:LinkButton>

    <br />

    

    <h1> Buscar Veiculo </h1>

    <asp:Label ID="lblBV" runat="server" Text="Veiculo:  "></asp:Label>
    <asp:TextBox ID="txtBV" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblBVC" runat="server" Text="Cor: "></asp:Label>
    <asp:TextBox ID="txtBVC" runat="server"></asp:TextBox>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"  />
    <br />

    <h1>Editar Veiculo</h1>

    <asp:Label ID="lblEditV" runat="server" Text="Editar Veiculo: "></asp:Label>
    
    <asp:TextBox ID="txtEdtV" runat="server"></asp:TextBox>
    <br />
     <asp:Label ID="lvlEditVCor" runat="server" Text="Editar Cor: "></asp:Label>
    
    <asp:TextBox ID="txtEditVCor" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnEditarV" runat="server" Text="Salvar" OnClick="btnEditarV_Click"  />


    <h1>Excluir Veiculo</h1>

    <asp:Label ID="lblExcV" runat="server" Text="Excluir Veiculo: "></asp:Label>
    
    <asp:TextBox ID="txtExcv" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblExVcor" runat="server" Text="Excluir Cor: "></asp:Label>
    
    <asp:TextBox ID="txtExVcor" runat="server"></asp:TextBox>

    <br />
    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click"  />

            </ContentTemplate>
         </asp:UpdatePanel>

</asp:Content>
