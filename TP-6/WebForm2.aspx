<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TP_6.BD_Connection.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/tailwindcss@2.2.19/dist/tailwind.min.css" rel="stylesheet">
    <title>Inicio</title>
</head>
<body>
    <h1>Inico</h1>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="SelectProductsLink" runat="server" PostBackUrl="~/SelectProducts.aspx">LinkButton</asp:LinkButton>
            <asp:LinkButton ID="RestoreSelectionLink" runat="server" PostBackUrl="~/RestoreProducts.aspx">LinkButton</asp:LinkButton>
            <asp:LinkButton ID="ShowSelectionLink" runat="server" PostBackUrl="~/ShowSelected.aspx">LinkButton</asp:LinkButton>
        </div>
    </form>
</body>
</html>
