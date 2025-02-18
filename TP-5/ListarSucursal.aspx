<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarSucursal.aspx.cs" Inherits="TP_5.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Listar Sucursal</title>
<script src="https://kit.fontawesome.com/e31ccd8e46.js" crossorigin="anonymous"></script>
    <link rel="stylesheet" type="text/css" href="./styles/main.css" />
</head>
<body>
        <form id="form1" runat="server">
        <div class="form-container">
            <nav class="nav">
                <h1 class="lato-bold">Listado de Sucursales 📚</h1>
                <ul>
                    <li class="nav-item">
                        <asp:HyperLink ID="Hlink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx" CssClass="nav-link">
                            Agregar Sucursal 🔼
                        </asp:HyperLink>
                    </li>
                    <li class="nav-item">
                        <asp:HyperLink ID="Hlink2" runat="server" NavigateUrl="~/ListarSucursal.aspx" CssClass="nav-link">
                            Listado de Sucursales 📚
                        </asp:HyperLink>
                    </li>
                    <li class="nav-item">
                        <asp:HyperLink ID="Hlink3" runat="server" NavigateUrl="~/EliminarSucursal.aspx" CssClass="nav-link">
                            Eliminar Sucursal ❌
                        </asp:HyperLink>
                    </li>
                </ul>
            </nav>

            <section class="search-section">
                <div class="search-bar">
                    <asp:TextBox ID="TxtID" placeholder="Ingrese ID de sucursal:" runat="server" CssClass="input"></asp:TextBox>
                    <asp:Button ID="filtro" runat="server" Text="🔎" OnClick="filtro_Click" ValidationGroup="Vg1" CssClass="btn btn-filter" />
                </div>

                <asp:Button ID="Mostrar" runat="server" Text="Mostrar todo" OnClick="Mostrar_Click" CssClass="btn btn-show-all" />
            </section>

            <section class="grid-section">
                <asp:GridView ID="grdSucursales" runat="server"></asp:GridView>
            </section>
                
        </div>
    </form>
</body>
</html>
