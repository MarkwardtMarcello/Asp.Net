<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Aula1005.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>TEXTO LEGAL!!</h2>
    <h3>Pagina de descrição da sua apliação</h3>
    <p>Use this area to provide additional information.</p>
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <br />
    <br />
    <asp:TextBox ID="txbData" runat="server"></asp:TextBox>
    <br />
    <br />

</asp:Content>
