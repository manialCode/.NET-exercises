<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TP_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <script src="https://unpkg.com/@tailwindcss/browser@4"></script>
 
    <title></title>
</head>
<body class="grid place-content-center h-screen w-screen">
    <form id="form1" runat="server" class="[&>h2]:text-xl [&>h2]:font-bold [&>h2]:text-center [&>h2]:py-5">
        <h2>Localidades</h2>
        <div id="Localidad" class="flex flex-col items-center justify-center">
            <asp:Label ID="Label2" runat="server" Text="Nombre de localidad"></asp:Label>
            <asp:TextBox ID="localidad" runat="server" CssClass="border"></asp:TextBox>
            <asp:Label ID="Label10" runat="server" Text="Codigo Postal"></asp:Label>
            <asp:TextBox ID="txbPostal" CssClass="border" runat="server"></asp:TextBox>
            <asp:Button ID="btnGuardarLocalidad" runat="server" OnClick="GuardarLocalidad" CssClass="text-sm px-4 py-2 font-semibold hover:bg-gray-200 rounded border mt-4" Text="Guardar localidad" />
        </div>
        <h2>Usuarios</h2>
        <div class="flex flex-col justify-center items-center">
            <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txbNombre" runat="server" CssClass="border" OnTextChanged="txbNombre_TextChanged"></asp:TextBox>

            <asp:Label ID="Label4" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txbPass" runat="server" CssClass="border"></asp:TextBox>

            <asp:Label ID="Label5" runat="server" Text="Repetir"></asp:Label>
            <asp:TextBox ID="txbRepetir" runat="server" CssClass="border"></asp:TextBox>

            <asp:Label ID="Label6" runat="server" Text="Correo"></asp:Label>
            <asp:TextBox  ID="txbEmail" runat="server"  CssClass="border"></asp:TextBox>

            <asp:Label ID="Label7" runat="server" Text="CP:"></asp:Label>
            <asp:TextBox ID="txbCP" runat="server" CssClass="border" ></asp:TextBox>

            <asp:Label ID="Label8" runat="server" Text="Localidades:"></asp:Label>
            <asp:DropDownList ID="ddlLocalidades" CssClass="border w-[200px]" runat="server"></asp:DropDownList>
            <asp:Button ID="btnGuardarUsuario" runat="server" CssClass="text-sm px-4 py-2 font-semibold hover:bg-gray-200 rounded border mt-4" Text="Guardar Usuario" />
        </div>
    </form>
</body>
</html>
