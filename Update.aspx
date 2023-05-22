<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Examen_Parcial2.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Actualizar Animal</h1>
    <p>
        Buscar:<asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
    </p>
    <p>
        <asp:Label ID="lblNombreAnimal" runat="server"></asp:Label>
    </p>
    <p>
        Actualizar:
        <asp:TextBox ID="txtUpdate" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="btnUpdate" runat="server" Enabled="False" OnClick="btnUpdate_Click" Text="Actualizar" />
    </p>
</asp:Content>
