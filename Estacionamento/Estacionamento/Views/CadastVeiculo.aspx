<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastVeiculo.aspx.cs" Inherits="Estacionamento.Views.CadastVeiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

    <h1>Cadastrar Veiculo/Buscar Veiculo</h1>

    
    
    <asp:TextBox ID="txtNomeV" runat="server"></asp:TextBox>
    <br />
            <asp:Label ID="lblVcor" runat="server" Text="Cor: "></asp:Label>
    
    <asp:TextBox ID="txtVCor" runat="server"></asp:TextBox>
            <br/>
    <asp:Label ID="lblNomeCliente" runat="server" Text="Cliente: "></asp:Label>
    <asp:DropDownList ID="dropdwClietV" runat="server" DataTextField="Nome" DataValueField="Id"></asp:DropDownList>
    <br />

    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click"   />
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"  />

    <h1> Veiculo Encontrado</h1>

    <asp:Label ID="lblBV" runat="server" Text="Veiculo Encontrado:  "></asp:Label>
    <asp:TextBox ID="txtBV" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblBVC" runat="server" Text="Cor: "></asp:Label>
    <asp:TextBox ID="txtBVC" runat="server"></asp:TextBox>
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
