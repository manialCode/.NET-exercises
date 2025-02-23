# TP_6 - Gestión de Productos

Este proyecto es una aplicación web para la gestión de productos, que permite seleccionar, visualizar y almacenar productos en una base de datos.

## Requisitos

- Visual Studio 2022
- .NET Framework 4.7.2
- SQL Server

## Configuración de la Base de Datos

1. Asegúrate de tener SQL Server instalado y en funcionamiento.
2. Crea una base de datos llamada `Neptuno`.
3. Configura la cadena de conexión en el archivo `BD_Connection/DataAccess.cs` según tu entorno de SQL Server.


## Estructura del Proyecto

- **BD_Connection**: Contiene la clase `DataAccess` para manejar las operaciones de la base de datos.
- **SelectProducts.aspx**: Página para seleccionar productos.
- **ShowSelected.aspx**: Página para mostrar los productos seleccionados.
- **WebForm2.aspx**: Página adicional para funcionalidades extendidas.

## Uso

### Seleccionar Productos

1. Navega a `SelectProducts.aspx`.
2. Selecciona un producto de la lista.
3. El producto seleccionado se añadirá a la sesión del usuario.

### Mostrar Productos Seleccionados

1. Navega a `ShowSelected.aspx`.
2. Visualiza los productos que has seleccionado previamente.
