<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Libros.aspx.cs" Inherits="sidneyalvarezexamenfinal.Libros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            color: #FF9900;
            text-align: center;
        }
        .auto-style2 {
            width: 266px;
            height: 241px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>BIBLIOTECA DE COSTA RICA
            <br />
            <br />
            </strong>
            <img alt="" class="auto-style2" src="imagenes/library-building-rgb-color-icon-vector.jpg" /></div>
        <p>
            Nombre del libro:&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tlibro" ErrorMessage="RequiredFieldValidator" ForeColor="#FFCC00">Ingrese nombre del libro </asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:TextBox ID="tlibro" placeholder="Nombre completo del libro" runat="server" OnTextChanged="TextBox1_TextChanged" Width="1208px"></asp:TextBox>
        </p>
        <p>
            ID Autor:&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="tautor" ForeColor="#FF9933">Ingrese el ID del autor</asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:TextBox ID="tautor" placeholder="Codigo del autor del libro" runat="server" Width="1208px"></asp:TextBox>
        </p>
        <p>
            Ubicacion del Libro:
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tubicacion" ErrorMessage="RequiredFieldValidator" ForeColor="#FFCC00">Ingrese la ubicacion del libro</asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:TextBox ID="tubicacion" placeholder="Biblioteca o libreria en donde se encuentre el libro" runat="server" Width="1208px"></asp:TextBox>
        </p>
        <p>
            Fecha de Publicacion:
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tpublicacion" ErrorMessage="RequiredFieldValidator" ForeColor="#FF6600">Ingrese una fecha de publicacion</asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:TextBox ID="tpublicacion" placeholder="Fecha en la que se publico el libro" runat="server" Width="1207px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Bagregar" runat="server" BackColor="#FFCC66" ForeColor="Black" Height="85px" Text="Agregar" Width="196px" />
&nbsp;<asp:Button ID="Beliminar" runat="server" BackColor="#FFFF99" Height="85px" Text="Eliminar" Width="196px" />
&nbsp;<asp:Button ID="Bactualizar" runat="server" BackColor="#FFCCCC" Height="85px" Text="Actualizar" Width="196px" />
        </p>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Height="229px" Width="1218px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
    </form>
</body>
</html>
