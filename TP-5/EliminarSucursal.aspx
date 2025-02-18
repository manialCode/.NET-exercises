<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="TP_5.EliminarSucursalaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <link rel="stylesheet" type="text/css" href="./styles/main.css" />
    <title>Eliminar Sucursal</title>
</head>
<body>
      <form id="form1" runat="server">
        <div>
            <nav class="nav">
                <h1 class="lato-bold">Eliminar sucursal ❌</h1>
                <ul>
                    <li class="nav-item">
                        <asp:HyperLink ID="Hlink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx" CssClass="nav-link">
Agregar Sucursal 🔼
                        </asp:HyperLink></li>
                    <li class="nav-item">
                        <asp:HyperLink ID="Hlink2" runat="server" NavigateUrl="~/ListarSucursal.aspx" CssClass="nav-link">
Listado de Sucursales 📚
                        </asp:HyperLink></li>
                    <li class="nav-item">
                        <asp:HyperLink ID="Hlink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx" CssClass="nav-link">
Eliminar Sucursal ❌
                        </asp:HyperLink></li>
                </ul>
            </nav>

        </div>
        <div class="container ej3">
                <section class="form-group">
                    <label for="txtIDSucursal" class="label">Ingresar ID Sucursal:</label>
                    <asp:TextBox ID="txtIDSucursal" runat="server" CssClass="input-field" placeholder="Ingrese ID de sucursal:" ValidationGroup="Grupo1"></asp:TextBox>
                </section>

                <section class="form-group">
                    <asp:Button ID="btnEliminar" CssClass="btn" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
                </section>

            </div>
            <section class="form-group  text-center">
                <asp:Label ID="lblMensaje" runat="server" EnableTheming="False" ForeColor="Red"></asp:Label>
            </section>

    </form>
</body>
</html>
