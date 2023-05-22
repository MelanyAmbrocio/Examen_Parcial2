<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Examen_Parcial2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ingreso Animales</h1>
        <p>Ingreso de Aves</p>
        <p>Nombre:
            <asp:TextBox ID="txtNombre" runat="server" Width="146px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Especie:&nbsp;
            <asp:TextBox ID="txtEspecie" runat="server"></asp:TextBox>
        </p>
        <p>Tipo alimentación:
            <asp:TextBox ID="txtAlimentacion" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Tiempo de vida:
            <asp:TextBox ID="txtVida" runat="server" Width="128px"></asp:TextBox>
        </p>
        <p>Vuela si/no:
            <asp:TextBox ID="txtVolador" runat="server"></asp:TextBox>
        </p>
        <p>Período de Incubación:
            <asp:TextBox ID="txtIncubacion" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar Ave" Width="172px" />
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
