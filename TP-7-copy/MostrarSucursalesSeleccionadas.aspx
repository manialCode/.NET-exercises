<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarSucursalesSeleccionadas.aspx.cs" Inherits="TP_7_copy.MostrarSucursalesSeleccionadas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="https://unpkg.com/@tailwindcss/browser@4"></script>
    <title></title>
</head>
<body class="bg-gray-100 flex flex-col items-center justify-center min-h-screen p-6">

    <form id="form1" runat="server" class="bg-white shadow-lg rounded-lg p-8 max-w-5xl w-full border border-gray-300">

        <!-- Navbar -->
        <nav class="flex justify-between mb-6">
            <asp:LinkButton ID="ListadoDeSucursales" runat="server" PostBackUrl="~/ListadoDeSucursales.aspx"
                CssClass="text-purple-700 hover:underline text-lg font-semibold">
                Listado de Sucursales
            </asp:LinkButton>

            <asp:LinkButton ID="MostrarSucursalesSeleccionadas" runat="server" PostBackUrl="~/MostrarSucursalesSeleccionadas.aspx"
                CssClass="text-purple-700 hover:underline text-lg font-semibold">
                Mostrar Selecciones
            </asp:LinkButton>
        </nav>
             <!-- Mensaje de Fallback -->
     <asp:Label ID="lbl_fallback" runat="server" CssClass="block text-lg text-gray-500 mb-4"></asp:Label>

        <div class="overflow-x-auto border border-gray-300 rounded-lg shadow-md">
            <asp:GridView ID="grdSelecciones" runat="server" CssClass="gridview-table w-full bg-white border border-gray-300 rounded-lg shadow-md overflow-hidden">
                <HeaderStyle CssClass="bg-purple-700 text-white text-left uppercase tracking-wider" />
                <RowStyle CssClass="bg-gray-100 text-gray-700 border-b border-gray-300" />
                <AlternatingRowStyle CssClass="bg-white" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
