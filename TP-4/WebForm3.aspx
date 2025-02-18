<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="TP_4.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Elegir Tema</h2>
            <asp:DropDownList ID="ddlTemas" runat="server"></asp:DropDownList>
            <asp:LinkButton ID="showBooks" runat="server" OnClick="showBooks_Click">Ver Libros</asp:LinkButton>
        </div>
    </form>
</body>
</html>
