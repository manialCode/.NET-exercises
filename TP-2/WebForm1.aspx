<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TP_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>TP 2 EJ1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Producto"></asp:Label>
            <asp:TextBox runat="server" ID="tbxP"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Producto"></asp:Label>
            <asp:TextBox runat="server" ID="tbx2"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Cantidad"></asp:Label>
            <asp:TextBox runat="server" ID="cant1"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Cantidad"></asp:Label>
            <asp:TextBox runat="server" ID="cant2"></asp:TextBox>  
        </div>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblInjection" runat="server" Text=""></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="button" />
    </form>
</body>
</html>
