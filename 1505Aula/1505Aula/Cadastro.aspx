<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="_1505Aula.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="upnCampos" runat="server">
        <ContentTemplate>
            <div class="row">
                <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNome" runat="server" ErrorMessage="Este Campo é obrigatório" ControlToValidate="txtNome"> </asp:RequiredFieldValidator>
            </div>
            <div class="row">
                <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
                <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="row">   
                <asp:Label ID="lblAtivo" runat="server" Text="Ativo"></asp:Label>
                <asp:CheckBox ID="chkAtivo" runat="server" />
            </div>
            <div class="row">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="false" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>