<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TP_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Viajes</h1>
        <div>
            <h2>Inicio</h2>
            <span>Provincia</span><asp:DropDownList ID="ddlProvinciaInicio" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProvinciaInicio_SelectedIndexChanged"></asp:DropDownList>
            <span>Localidad</span><asp:DropDownList ID="ddlLocalidadInicio" runat="server"></asp:DropDownList>
        </div>
        <div>
            <h2>Final</h2>
            <span>Provincia</span><asp:DropDownList ID="ddlProvinciaFin" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProvinciaFin_SelectedIndexChanged"></asp:DropDownList>
            <span>Localidad</span><asp:DropDownList ID="ddlLocalidadFin" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
