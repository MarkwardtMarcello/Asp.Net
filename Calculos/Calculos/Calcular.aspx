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
        <asp:TextBox ID="txtNumMenos" runat="server"></asp:TextBox>  
        
        <asp:TextBox ID="txtNumMenos2" runat="server"></asp:TextBox>
        <asp:Button ID="btnMenos" runat="server" Text="-" OnClick="btnMenos_Click"    /> 
        <asp:Button ID="btnIgualMenos" runat="server" Text="="  />
        <asp:Label ID="lblMenos" runat="server" Text="A subtração é: "></asp:Label>
        <asp:TextBox ID="txtResultMenos" runat="server"></asp:TextBox>
        <br/>
        <asp:TextBox ID="txtNumVezes" runat="server"></asp:TextBox>  
        
        <asp:TextBox ID="txtNumVezes2" runat="server"></asp:TextBox>
        <asp:Button ID="btnVezes" runat="server" Text="x" OnClick="btnVezes_Click"  /> 
        <asp:Button ID="btnIgualVezes" runat="server" Text="="  />
        <asp:Label ID="lblVezes" runat="server" Text="A multiplicação é: "></asp:Label>
        <asp:TextBox ID="txtResulVezes" runat="server"></asp:TextBox>
        <br/>
        <asp:TextBox ID="txtNumDiv" runat="server"></asp:TextBox>  
        
        <asp:TextBox ID="txtNumDiv2" runat="server"></asp:TextBox>
        <asp:Button ID="btnDiv" runat="server" Text="/" OnClick="btnDiv_Click"    /> 
        <asp:Button ID="btnIgualDiv" runat="server" Text="="  />
        <asp:Label ID="lblDiv" runat="server" Text="A divisão é: "></asp:Label>
        <asp:TextBox ID="txtResulDiv" runat="server"></asp:TextBox>
        <br/>







</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
