<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="TP_2.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Configura tu PC" />

            <asp:DropDownList runat="server" ID="ddlMemory"></asp:DropDownList>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Accesorios"></asp:Label>
            <asp:CheckBoxList runat="server" ID="cblDisplays"></asp:CheckBoxList>
            <br />
            <asp:Label ID="lblPrecioFinal" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="btn" runat="server" Text="Calcular precio" OnClick="calculate" />
        </div>
    </form>
</body>
</html>
