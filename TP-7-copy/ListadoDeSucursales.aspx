<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoDeSucursales.aspx.cs" Inherits="TP_7_copy.ListadoDeSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

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

        <!-- Encabezado y Búsqueda -->
        <header class="text-purple-900 p-6 text-center mb-6">
            <h1 class="text-3xl font-bold">Listado de Sucursales</h1>
            <p class="text-lg mt-2">Búsqueda por nombre</p>

            <div class="flex flex-col md:flex-row gap-4 justify-center items-center mt-4 space-x-4">
                <asp:TextBox ID="txtNombreSucursal" runat="server"
                    CssClass="px-4 py-2 w-64 border border-gray-300 rounded-md shadow-sm focus:outline-none focus:ring-2 focus:ring-purple-400" />

                <asp:Button ID="btnBuscar" OnClick="btnBuscar_Click" runat="server" Text="Buscar"
                    CssClass="px-4 py-2 bg-purple-600 text-white rounded-md shadow-md hover:bg-purple-700 transition"
                    />

            </div>
        </header>

        <main class="grid md:grid-cols-[auto_1fr] gap-6">

            <!-- Botones de provincias -->
            <section id="Provincias" class="flex flex-col md:justify-between gap-4 max-h-[700px]">
                <asp:DataList ID="DataList1" runat="server" DataKeyField="Id_Provincia" DataSourceID="SqlDataSource2">
                    <ItemTemplate>
                        Id_Provincia:
                        <asp:Label Text='<%# Eval("Id_Provincia") %>' runat="server" ID="Id_ProvinciaLabel" /><br />
                        DescripcionProvincia:
                        <asp:Label  runat="server" ID="DescripcionProvinciaLabel" /><br />
                        <br />
                        <asp:Button ID="BtnProvincia" runat="server"
                            CssClass="px-4 py-2 bg-purple-600 text-white rounded-md shadow-md hover:bg-purple-700 transition"
                            Text='<%# Eval("DescripcionProvincia") %>'
                            CommandName="SelectProvincie"
                            CommandArgument='<%# Eval("Id_Provincia") %>'
                            OnCommand="BtnProvincia_Command"
                            />
                    </ItemTemplate>
                </asp:DataList>
             </section>

            <section id="Sucursales">
                <asp:ListView ID="lvSucursales" OnPagePropertiesChanging="lvSucursales_PagePropertiesChanging" runat="server" DataSourceID="SqlDataSource1" DataKeyNames="Id_Sucursal" GroupItemCount="3">
                    <EmptyDataTemplate>
                        <div class="text-center text-gray-500 p-6">
                            No se han devuelto datos.
                   
                        </div>
                    </EmptyDataTemplate>
                    <EmptyItemTemplate>
                        <div class="text-center text-gray-500 p-6"></div>
                    </EmptyItemTemplate>

                    <ItemTemplate>
                        <div class="border border-gray-300 rounded-lg p-4 shadow-md bg-white flex flex-col justify-between">
                            <asp:ImageButton ID="URL_Imagen_SucursalButton" runat="server" ImageAlign="Middle"
                                ImageUrl='<%# Eval("URL_Imagen_Sucursal") %>' CssClass="w-full h-48 object-cover rounded-md" />
                            <h3 class="text-lg font-bold text-gray-800 mt-4">
                                <asp:Label Text='<%# Eval("NombreSucursal") %>' runat="server" ID="NombreSucursalLabel" />
                            </h3>
                            <p class="text-sm text-gray-600">
                                <asp:Label Text='<%# Eval("DescripcionSucursal") %>' runat="server" ID="DescripcionSucursalLabel" />
                            </p>
                            <asp:Button ID="BtnSeleccionar" runat="server"
                                Text="Seleccionar"
                                CssClass="mt-2 bg-green-600 text-white px-4 py-2 rounded-lg shadow-md hover:bg-green-700 transition"
                                CommandName="Select"
                                CommandArgument='<%# Eval("Id_Sucursal") + "|" + Eval("NombreSucursal") + "|" + Eval("DescripcionSucursal") %>'
                                OnCommand="BtnSeleccionar_Command" />
                        </div>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-3">
                            <asp:PlaceHolder runat="server" ID="groupPlaceholder"></asp:PlaceHolder>
                        </div>
                        <div class="flex justify-center mt-4">
                            <asp:DataPager runat="server" PageSize="6" ID="DataPager1" CssClass="flex space-x-2">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"
                                        ButtonCssClass="px-4 py-2 bg-purple-600 text-white rounded-md shadow-md hover:bg-purple-700 transition" />
                                    <asp:NumericPagerField />
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"
                                        ButtonCssClass="px-4 py-2 bg-purple-600 text-white rounded-md shadow-md hover:bg-purple-700 transition" />
                                </Fields>
                            </asp:DataPager>
                        </div>
                    </LayoutTemplate>
                    <GroupTemplate>
                        <tr runat="server" id="itemPlaceholderContainer">
                            <td runat="server" id="itemPlaceholder"></td>
                        </tr>
                    </GroupTemplate>
                    <SelectedItemTemplate>
                        <td runat="server" style="">Id_Sucursal:
                        <asp:Label Text='<%# Eval("Id_Sucursal") %>' runat="server" ID="Id_SucursalLabel" /><br />
                            NombreSucursal:
                        <asp:Label Text='<%# Eval("NombreSucursal") %>' runat="server" ID="NombreSucursalLabel" /><br />
                            DescripcionSucursal:
                        <asp:Label Text='<%# Eval("DescripcionSucursal") %>' runat="server" ID="DescripcionSucursalLabel" /><br />
                            Id_ProvinciaSucursal:
                        <asp:Label Text='<%# Eval("Id_ProvinciaSucursal") %>' runat="server" ID="Id_ProvinciaSucursalLabel" /><br />
                            URL_Imagen_Sucursal:
                        <asp:Label Text='<%# Eval("URL_Imagen_Sucursal") %>' runat="server" ID="URL_Imagen_SucursalLabel" /><br />
                        </td>
                    </SelectedItemTemplate>
                </asp:ListView>
            </section>
        </main>
    </form>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:BDSucursalesConnectionString %>' ProviderName='<%$ ConnectionStrings:BDSucursalesConnectionString.ProviderName %>' SelectCommand="SELECT [Id_Sucursal], [NombreSucursal], [DescripcionSucursal], [Id_ProvinciaSucursal], [URL_Imagen_Sucursal] FROM [Sucursal]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString='<%$ ConnectionStrings:BDSucursalesConnectionString %>' SelectCommand="SELECT DISTINCT [Id_Provincia], [DescripcionProvincia] FROM [Provincia]"></asp:SqlDataSource>
</body>
</html>
