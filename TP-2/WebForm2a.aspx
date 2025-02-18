<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2a.aspx.cs" Inherits="TP_2.WebForm2a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label><asp:TextBox ID="txbName" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label><asp:TextBox ID="txbLastName" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Ciudad"></asp:Label><asp:DropDownList ID="ddlCity" runat="server"></asp:DropDownList>
            <asp:Label ID="Label4" runat="server" Text="Temas"></asp:Label><asp:CheckBoxList ID="cblSubjects" runat="server"></asp:CheckBoxList>
        </div>
            <asp:Button ID="btnSend" runat="server" Text="Button" OnClick="HandleClick" />
            <asp:Label ID="lblError" runat="server" Text="Temas"></asp:Label>
    </form>
</body>
</html>
