# TP_5 - Gestión de Sucursales

## Descripción del Proyecto

TP_5 es una aplicación web desarrollada en ASP.NET que permite gestionar sucursales. La aplicación permite listar, agregar y eliminar sucursales, así como filtrar las sucursales por su ID. La base de datos utilizada es SQL Server.

## Características

- Listar todas las sucursales.
- Agregar nuevas sucursales.
- Eliminar sucursales existentes.
- Filtrar sucursales por ID.
- Utiliza una base de datos SQL Server para almacenar la información de las sucursales y provincias.

## Requisitos

- .NET Framework 4.7.2
- SQL Server
- Visual Studio 2022

## Instalación

1. Clona el repositorio en tu máquina local.
2. Abre el proyecto en Visual Studio 2022.
3. Configura la cadena de conexión a la base de datos en el archivo `ConexionBD.cs`.
4. Restaura los paquetes NuGet necesarios.
5. Ejecuta el script SQL para crear la base de datos y las tablas necesarias.

## Uso

### Listar Sucursales

La página `ListarSucursal.aspx` permite listar todas las sucursales y filtrar por ID.

### Agregar Sucursales

La página `AgregarSucursal.aspx` permite agregar nuevas sucursales a la base de datos.

### Eliminar Sucursales

La página `EliminarSucursal.aspx` permite eliminar sucursales existentes de la base de datos.

## Estructura del Proyecto

- **ConexionBD.cs**: Clase que maneja la conexión a la base de datos y proporciona métodos para ejecutar consultas y transacciones.
- **ListarSucursal.aspx.cs**: Código detrás de la página que lista las sucursales.
- **AgregarSucursal.aspx.cs**: Código detrás de la página que agrega nuevas sucursales.
- **EliminarSucursal.aspx.cs**: Código detrás de la página que elimina sucursales.

## Contribuir

1. Haz un fork del proyecto.
2. Crea una nueva rama (`git checkout -b feature/nueva-funcionalidad`).
3. Realiza los cambios necesarios y haz commit (`git commit -am 'Añadir nueva funcionalidad'`).
4. Sube los cambios a tu repositorio (`git push origin feature/nueva-funcionalidad`).
5. Abre un Pull Request.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo [LICENSE](LICENSE) para más detalles.

## Contacto

Para cualquier consulta o sugerencia, por favor contacta a [juanmartinmonti4@gmail.com](mailto:juanmartinmonti4@gmail.com).
   