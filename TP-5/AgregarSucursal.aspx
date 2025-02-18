<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="TP_5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <link rel="stylesheet" type="text/css" href="./styles/main.css" />
<title>Agregar Sucursal</title>
</head>
<body>
       <form id="form1" runat="server">
            <nav class="nav">
                <h1 class="lato-bold">Agregar sucursal 🔼</h1>
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

        <div class="container ej1">
            <div class="form-group">
                <label for="txtNombreSuc">Nombre Sucursal</label>
                <asp:TextBox ID="txtNombreSuc" runat="server" CssClass="input-field" placeholder="Nombre Sucursal"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="txtDescripcionSuc">Descripción</label>
                <asp:TextBox ID="txtDescripcionSuc" runat="server" CssClass="input-field" placeholder="Descripción"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="DdlProvincias">Provincia</label>
                <asp:DropDownList ID="DdlProvincias" runat="server" CssClass="input-field" AutoPostBack="True">
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label for="txtDireccionSuc">Dirección</label>
                <asp:TextBox ID="txtDireccionSuc" runat="server" CssClass="input-field" placeholder="Dirección"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Button ID="BtnAceptar" runat="server" Text="Aceptar" OnClick="BtnAceptar_Click" CssClass="btn submit"  />
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
            </div>

        </div>
            <asp:ValidationSummary ID="Vs" runat="server" ValidationGroup="Vg1" CssClass="validation-summary err" />
    </form>
</body>
</html>
