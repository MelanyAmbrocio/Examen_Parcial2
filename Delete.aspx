<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Examen_Parcial2.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Eliminar Animal</h1>
    <p>
        Buscar:
        <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
    </p>
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblNombreAnimal" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" Enabled="False" OnClick="btnDelete_Click" Text="Eliminar" />
    </p>
</asp:Content>
