<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="TP_2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txbName" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txbPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" Text="Validar" OnClick="submit"/>
        </div>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
