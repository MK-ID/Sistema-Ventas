<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Privado.aspx.cs" Inherits="SeguridadFrontEnd.Intranet.Privado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Sitio privado, solo personal autorizado
            <br />
            Bienvenido<br />
            <asp:LoginName ID="LoginName1" runat="server" />
            <br />
            <br />
            <asp:LoginStatus ID="LoginStatus1" runat="server" />
            <br />
            <br />
            <br />
        </div>
        <!--Controles que permiten un mejor uso del esapcioo en un formulario-->
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button1" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Button2" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Button3" OnClick="Button3_Click" />
        </p>
        <asp:MultiView ID="mvOpciones" runat="server">
            <asp:View ID="vOpcion1" runat="server">
                Opcion 1
            </asp:View>
            <asp:View ID="vOpcion2" runat="server">
                Opcion 2
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </asp:View>
            <asp:View ID="vOpcion3" runat="server">
                Opcion 3
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Text="text1" />
                    <asp:ListItem Text="text2" />
                    <asp:ListItem Text="text3" />
                </asp:DropDownList>
            </asp:View>
        </asp:MultiView>
  </form>
</body>
</html>
