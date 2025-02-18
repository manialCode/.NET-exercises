<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TP_4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="https://unpkg.com/@tailwindcss/browser@4"></script>
    <style>
 
 
    :root {
        /* Colores de tema claro */
        --clr-primary-100: #C1FF57;
        --clr-primary-400: #7CB842;
        --clr-accent-100: #FFEA00;
        --clr-accent-400: #B3A500;
        --clr-neutral-100: #FFFFFF;
        --clr-text-primary: #1C1C1C;
        --clr-background-light: #FFFFFF;
        --clr-background-section: #F9F9F9;
        --clr-background: var(--clr-background-light);
    }


:root {
    --input-text-color: var(--clr-text-primary);
    --input-bg-color: var(--clr-background-light); 
    --input-border-color: var(--clr-primary-400);
    --input-focus-border-color:var(--clr-accent-100); 
    --input-focus-shadow-color: rgba(1, 39, 9, 0.3); 
    --shadow-color: rgba(1, 39, 9, 0.3); 
}    
table {
    width: 80%;
    background-color: var(--clr-background-dark);
    border-collapse: collapse !important;
    margin: auto;
    border-radius: 1rem;
}

th, td, caption {
    padding: 1rem;
}

table caption, table th {
    text-align: left;
}

table caption {
    background: var(--clr-accent-400);
    color: inherit;
    font-size: 1.5rem;
    font-weight: 700;
    text-transform: uppercase;
}

table th {
    background-color:#000;
    color: var(--clr-accent-100);
}

table tr {
    transition: all 500ms ease;
}

    table tr:has(td):hover {
        background-color: hsl(0 0% 80%);
        color: var(--clr-neutral-100);
    }

    table tr:nth-child(even) {
        background: hsl(0 0% 30% / 0.1);
    }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="p-10 flex gap-x-4 items-center [&>div>span]:font-bold [&>div>span]:text-xl">
            <div>
            <span>Id Producto</span>
            <asp:DropDownList ID="ddlEvalFiltroID" CssClass="border px-1 rounded" runat="server" Enabled="True"></asp:DropDownList>
            <asp:TextBox ID="txbIdProducto" CssClass="border rounded" runat="server"></asp:TextBox>
            </div>
            <div>
            <span>Id Categoría</span>
            <asp:DropDownList CssClass="border px-1 rounded" ID="ddlEvalFiltroCat" runat="server"></asp:DropDownList>
            <asp:TextBox ID="txbIdCat" CssClass="border rounded" runat="server"></asp:TextBox>

            </div>
            <div class="">
            <asp:Button ID="btnFiltrar" OnClick="Set_Filter" CssClass="text-sm px-4 py-2 font-semibold hover:bg-gray-200 rounded border mt-4" runat="server" Text="Filtrar" />
            <asp:Button ID="btnLimpiarFiltro" OnClick="Clear_Filter" CssClass="text-sm px-4 py-2 font-semibold hover:bg-red-500/60 hover:text-white rounded border mt-4" runat="server" Text="Reiniciar" />

            </div>
        </div>
        <div class="p-10 text-center">
            <asp:GridView ID="grvProductos" CssClass="" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
