# TP_7_copy

Este proyecto es una aplicación web desarrollada en ASP.NET que permite a los usuarios listar y seleccionar sucursales de una base de datos.

## Requisitos

- .NET Framework 4.7.2
- Visual Studio 2022

## Instalación

1. Clona el repositorio en tu máquina local.
2. Abre el proyecto en Visual Studio 2022.
3. Restaura los paquetes NuGet necesarios.
4. Configura la cadena de conexión a la base de datos en el archivo `web.config`.

## Uso

### Listado de Sucursales

La página `ListadoDeSucursales.aspx` permite a los usuarios listar las sucursales filtradas por provincia y buscar sucursales por nombre.

#### Métodos Principales

- `Page_Load`: Carga inicial de la página.
- `CargarSucursales`: Carga las sucursales de una provincia específica.
- `BtnSeleccionar_Command`: Maneja el evento de selección de una sucursal.
- `btnBuscar_Click`: Maneja el evento de búsqueda de sucursales por nombre.

### Mostrar Sucursales Seleccionadas

La página `MostrarSucursalesSeleccionadas.aspx` muestra las sucursales que el usuario ha seleccionado.

#### Métodos Principales

- `Page_Load`: Carga inicial de la página y muestra las sucursales seleccionadas.

## Clases Principales

### SucursalService

Esta clase maneja la lógica de negocio relacionada con las sucursales.

#### Métodos

- `ObtenerSucursalesPorProvincia`: Obtiene la lista de sucursales filtradas por provincia.
- `BuscarSucursales`: Busca sucursales por nombre.

### DataAccess

Esta clase maneja las operaciones de base de datos.

#### Métodos

- `CreateConnection`: Crea y abre una conexión a la base de datos.
- `GetAdapter`: Obtiene un adaptador de datos para una consulta.
- `ExecuteStoredProcedure`: Ejecuta un procedimiento almacenado.
- `ExecuteQuery`: Ejecuta una consulta y devuelve el resultado como un DataTable.

## Contribuciones

Las contribuciones son bienvenidas. Por favor, abre un issue o envía un pull request para discutir cualquier cambio que desees realizar.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo `LICENSE` para obtener más detalles.
