<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vendedor.aspx.cs" Inherits="CapaWeb.Vendedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Mantenimiento de la tabla Vendedor</h3>
    <p>CodVendedor: <asp:TextBox runat="server" ID="txtCodVendedor"/></p>
    <p>Apellidos: <asp:TextBox runat="server" ID="txtApellidos"/></p>
    <p>Nombres: <asp:TextBox runat="server" ID="txtNombres"/></p>
    <p>Usuario: <asp:TextBox runat="server" ID="txtUsuario"/></p>
    <p>Contraseña: <asp:TextBox runat="server" ID="txtContrasena"/></p>
    <p> 
        <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click" />
        <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" />
        <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" />
    </p>
    <asp:GridView runat="server" ID="gvVendedor">

    </asp:GridView>
</asp:Content>
