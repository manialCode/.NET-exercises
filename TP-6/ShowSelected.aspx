<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowSelected.aspx.cs" Inherits="TP_6.ShowSelected" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/tailwindcss@2.2.19/dist/tailwind.min.css" rel="stylesheet">

    <title></title>
</head>
<body class="bg-gray-50 flex items-center justify-center min-h-screen p-6">

    <form id="form1" runat="server" class="bg-white shadow-xl rounded-2xl p-10 max-w-3xl w-full text-center border border-gray-200">
        
        <!-- Título -->
        <h1 class="text-3xl font-bold text-purple-700 mb-6">Productos Seleccionados</h1>

        <!-- Mensaje de Fallback -->
        <asp:Label ID="lbl_fallback" runat="server" CssClass="block text-lg text-gray-500 mb-4"></asp:Label>

        <!-- Contenedor de la tabla con Scroll Responsivo -->
        <div class="overflow-x-auto border border-gray-300 rounded-lg shadow-md">
            <asp:GridView
                ID="grd_Products"
                runat="server"
                AllowPaging="True"
                PageSize="10"
                 OnRowDataBound="grd_Products_RowDataBound"
                CssClass="w-full border-collapse"
                PagerStyle-CssClass="w-full flex justify-center space-x-2 p-4 bg-purple-600 text-white rounded-b-lg"
                HeaderStyle-CssClass="bg-purple-700 text-white p-4 uppercase text-md tracking-wide"
                RowStyle-CssClass="bg-white text-gray-700 border-b border-gray-200 text-center p-3"
                AlternatingRowStyle-CssClass="bg-gray-100 text-gray-700"
                SelectedRowStyle-CssClass="bg-purple-200 font-bold"
                SortedAscendingHeaderStyle-CssClass="bg-purple-500"
                SortedDescendingHeaderStyle-CssClass="bg-purple-800">
            </asp:GridView>
        </div>

        <!-- Botón de regreso -->
        <div class="mt-6 text-center">
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/WebForm2.aspx"
                CssClass="inline-block px-6 py-3 bg-purple-600 text-white font-semibold rounded-lg shadow-md hover:bg-purple-700 transition">
                Volver al inicio
            </asp:LinkButton>
        </div>

    </form>

</body>
</html>
