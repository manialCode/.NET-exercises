<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TP_6.BD_Connection.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/tailwindcss@2.2.19/dist/tailwind.min.css" rel="stylesheet">
    <title>Inicio</title>
</head>
<body class="bg-gray-100 flex items-center justify-center min-h-screen">

    <form id="form1" runat="server" class="bg-white shadow-lg rounded-lg p-8 max-w-lg w-full text-center">
        <!-- Título -->
        <h1 class="text-3xl font-bold text-purple-700 mb-6">Inicio</h1>

        <!-- Contenedor de enlaces -->
        <div class="space-y-4">
            <asp:LinkButton ID="SelectProductsLink" runat="server" PostBackUrl="~/SelectProducts.aspx"
                CssClass="block w-full px-6 py-3 bg-blue-600 text-white font-semibold rounded-lg shadow-md hover:bg-blue-700 transition">
                Seleccionar Productos
            </asp:LinkButton>

            <asp:Button ID="btn_RestoreSelection" runat="server" OnClientClick="openModal(false); return false;"
                CssClass="block w-full px-6 py-3 bg-green-600 text-white font-semibold rounded-lg shadow-md hover:bg-green-700 transition" Text="Restaurar Selección">
            </asp:Button>

            <asp:LinkButton ID="ShowSelectionLink" runat="server" PostBackUrl="~/ShowSelected.aspx"
                CssClass="block w-full px-6 py-3 bg-purple-600 text-white font-semibold rounded-lg shadow-md hover:bg-purple-700 transition">
                Mostrar Selección
            </asp:LinkButton>
        </div>
  <!-- MODAL -->
    <div id="restoreModal" class="fixed inset-0 flex items-center justify-center bg-black bg-opacity-50 hidden">
        <div class="bg-white p-6 rounded-lg shadow-lg max-w-sm w-full text-center">
            <h2 class="text-xl font-bold mb-4 text-gray-700">Confirmación</h2>
            <p id="modalMessage" class="text-gray-600 mb-4">Esta acción restaurará la selección anterior.</p>

            <!-- Mensaje de éxito oculto inicialmente -->
            <p id="successMessage" class="text-green-600 font-bold hidden">¡Selección restaurada con éxito!</p>

            <div class="flex justify-center space-x-4">
                <button onclick="closeModal()" class="px-4 py-2 bg-gray-400 text-white rounded hover:bg-gray-500 transition">
                    Cerrar
                </button>
                <asp:Button ID="btnConfirmRestore" runat="server" OnClick="btnConfirmRestore_Click"
                    CssClass="px-4 py-2 bg-green-600 text-white rounded hover:bg-green-700 transition" Text="Confirmar">
                </asp:Button>
            </div>
        </div>
    </div>
    </form>


    <script>
        function openModal(noSelection) {
            document.getElementById('restoreModal').classList.remove('hidden');

            // Resetear mensajes
            document.getElementById('modalMessage').classList.remove('hidden');
            document.getElementById('successMessage').classList.add('hidden');

            if (noSelection) {
                document.getElementById('modalMessage').textContent = "Aún no se han hecho selecciones.";
                document.getElementById('btnConfirmRestore').style.display = "none"; // Oculta el botón "Confirmar"
            } else {
                document.getElementById('modalMessage').textContent = "Esta acción Eliminara todas las selecciones.";
                document.getElementById('btnConfirmRestore').style.display = "block"; // Muestra el botón "Confirmar"
            }
        }

        function closeModal() {
            document.getElementById('restoreModal').classList.add('hidden');
        }

        // Cuando el botón "Confirmar" es presionado, mostrar mensaje de éxito y cerrar el modal tras 2 segundos
        document.addEventListener("DOMContentLoaded", function () {
            var confirmButton = document.getElementById('<%= btnConfirmRestore.ClientID %>');

            confirmButton.addEventListener("click", function () {
                // Ocultar mensaje normal y botón de confirmar
                document.getElementById('modalMessage').classList.add('hidden');
                confirmButton.style.display = "none";

                // Mostrar mensaje de éxito
                document.getElementById('successMessage').classList.remove('hidden');

                // Cerrar modal automáticamente después de 2 segundos
                setTimeout(closeModal, 2000);
            });
        });
 </script>

</body>

</html>
