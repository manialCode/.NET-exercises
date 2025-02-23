# Proyecto TP_4

Este proyecto es una aplicación web ASP.NET que interactúa con una base de datos SQL Server para gestionar información de productos y libros. La aplicación permite filtrar productos y mostrar libros basados en temas seleccionados.

## Características

- Filtrado de productos por ID y categoría.
- Visualización de productos en una cuadrícula.
- Selección de temas y redirección a una página que muestra libros relacionados.

## Requisitos

- .NET Framework 4.7.2
- SQL Server
- Visual Studio 2022

## Instalación

1. Clona el repositorio en tu máquina local.
2. Abre el proyecto en Visual Studio 2022.
3. Configura la cadena de conexión en los archivos `.aspx.cs` para que apunte a tu instancia de SQL Server.
4. Asegúrate de que la base de datos `Neptuno` y `Libreria` estén disponibles y contengan las tablas necesarias (`Productos`, `temas`).

## Uso

### Filtrado de Productos

1. Navega a `WebForm2.aspx`.
2. Selecciona los criterios de filtrado (ID y categoría) y haz clic en "Aplicar Filtro".
3. Los productos filtrados se mostrarán en la cuadrícula.

### Visualización de Libros por Tema

1. Navega a `WebForm3.aspx`.
2. Selecciona un tema de la lista desplegable.
3. Haz clic en "Mostrar Libros" para ser redirigido a `WebForm3b.aspx` con los libros relacionados.

## Estructura del Proyecto

- **WebForm2.aspx.cs**: Maneja el filtrado y la visualización de productos.
- **WebForm3.aspx.cs**: Maneja la selección de temas y la redirección a la página de libros.
- **WebForm3b.aspx.cs**: Muestra los libros relacionados con el tema seleccionado.

## Contribuciones

Las contribuciones son bienvenidas. Por favor, abre un issue o envía un pull request para discutir cualquier cambio que te gustaría hacer.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo LICENSE para obtener más detalles.
