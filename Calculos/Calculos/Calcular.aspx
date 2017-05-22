<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calcular.aspx.cs" Inherits="Calculos.Calcular" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

        <br/><br/>
        <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>  
        
        <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
        <asp:Button ID="btnMais" runat="server" Text="+" OnClick="btnMais_Click"  /> 
        <asp:Button ID="btnIgual" runat="server" Text="=" OnClick="btnIgual_Click"  />
        <asp:Label ID="lblResultado" runat="server" Text="A soma é:  "></asp:Label>
        <asp:TextBox ID="txtResultadoMais" runat="server"></asp:TextBox>  
        <br/>
        
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
