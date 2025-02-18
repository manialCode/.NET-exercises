<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectProducts.aspx.cs" Inherits="TP_6.SelectProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/tailwindcss@2.2.19/dist/tailwind.min.css" rel="stylesheet">
    <title>Seleccion de productos</title>
</head>
<body class="bg-gray-100 flex items-center justify-center min-h-screen p-4">

    <form id="form1" runat="server" class="bg-white shadow-lg rounded-lg p-6 w-full max-w-4xl border border-gray-300">
        <h1 class="text-2xl font-bold text-purple-700 text-center mb-6">Selección de Productos</h1>
        
        <!-- Tabla de productos -->
        <div class="overflow-x-auto">
            <asp:GridView
                ID="grd_Products"
                runat="server"
                AllowPaging="True"
                AutoGenerateSelectButton="True"
                AutoGenerateColumns="false"
                OnPageIndexChanging="grd_Products_PageIndexChanging"
                PageSize="14"
                CssClass="w-full border border-gray-300 shadow-md rounded-lg overflow-hidden"
                PagerStyle-CssClass="w-full flex justify-center space-x-2 p-3 bg-purple-600 text-white"
                HeaderStyle-CssClass="bg-purple-700 text-white p-4 text-center uppercase text-sm"
                RowStyle-CssClass="bg-white text-gray-700 border-b border-gray-200"
                AlternatingRowStyle-CssClass="bg-gray-100 text-gray-700"
                SelectedRowStyle-CssClass="bg-purple-200 font-bold"
                SortedAscendingHeaderStyle-CssClass="bg-purple-400"
                SortedDescendingHeaderStyle-CssClass="bg-purple-600 w-full " 
                OnSelectedIndexChanging="grd_Products_SelectedIndexChanging">
                
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label ID="lblID" runat="server"
                                CssClass="block p-2 text-center font-semibold"
                                Text='<%# Eval("id") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                        <ItemTemplate>
                            <asp:Label ID="lblNombre" runat="server"
                                CssClass="block p-2 text-center"
                                Text='<%# Eval("Nombre") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Proveedor">
                        <ItemTemplate>
                            <asp:Label ID="lblProveedor" runat="server"
                                CssClass="block p-2 text-center"
                                Text='<%# Eval("Proveedor") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Precio Unitario">
                        <ItemTemplate>
                            <asp:Label ID="lblPrecio" runat="server"
                                CssClass="block p-2 text-center"
                                Text='<%# Eval("Precio") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

        <!-- Información seleccionada -->
        <div class="mt-6 text-gray-700">
            <asp:Label ID="lbl_ProductCount" runat="server" CssClass="text-gray-700 font-semibold text-lg mt-4 block"></asp:Label>
            <p class="font-semibold">Selección: <asp:Label ID="lbl_Selected_Product" runat="server" CssClass="text-purple-700 font-bold"></asp:Label></p>
            <p class="font-semibold">Última selección eliminada: <asp:Label ID="lbl_LastRow" runat="server" CssClass="text-red-600 font-bold"></asp:Label></p>
        </div>

        <!-- Botones -->
        <div class="mt-6 flex space-x-4 justify-center">
            <asp:Button ID="btn_clear_last" runat="server" Text="Eliminar última selección"
                CssClass="px-4 py-2 bg-red-500 text-white rounded-lg shadow hover:bg-red-700 transition"
                OnClick="btn_clear_last_Click" />
            
            <asp:Button ID="btn_clear" runat="server" Text="Eliminar todas las selecciones"
                CssClass="px-4 py-2 bg-gray-500 text-white rounded-lg shadow hover:bg-gray-700 transition"
                OnClick="btn_clear_Click" />
        </div>

        <!-- Enlace de regreso -->
        <div class="mt-6 text-center">
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/WebForm2.aspx.cs"
                CssClass="text-purple-600 hover:underline text-lg font-semibold">
                Volver al inicio
            </asp:LinkButton>
        </div>

    </form>
</body>
</html>
