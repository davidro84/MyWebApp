# YMAL - Aplicación Web ASP.NET Core

Una aplicación web moderna y responsiva desarrollada con ASP.NET Core MVC.

## Descripción

YMAL es una aplicación web básica que demuestra los conceptos fundamentales de ASP.NET Core MVC, incluyendo:
- Controladores y acciones
- Vistas Razor
- Formularios y validación
- Layout compartido
- Estilos CSS modernos

## Requisitos

- .NET 8.0 o superior instalado
- Visual Studio Code, Visual Studio o cualquier editor de texto
- navegador web moderno

## Ejecución

### Opción 1: Desde Visual Studio Code

1. Abre la carpeta del proyecto en VS Code
2. Abre una terminal integrada (Ctrl + `)
3. Ejecuta: `dotnet run`
4. Abre tu navegador en: `https://localhost:5001` o `http://localhost:5000`

### Opción 2: Compilar y ejecutar

```powershell
# Compilar el proyecto
dotnet build

# Ejecutar la aplicación
dotnet run

# Ejecutar con watch (reinicia automáticamente al cambiar archivos)
dotnet watch run
```

## Estructura del Proyecto

```
YMAL/
├── Controllers/           # Controladores MVC
│   └── HomeController.cs  # Controlador principal
├── Views/
│   ├── Home/              # Vistas para HomeController
│   │   ├── Index.cshtml   # Página de inicio
│   │   ├── About.cshtml   # Página de información
│   │   └── Contact.cshtml # Página de contacto
│   └── Shared/
│       ├── _Layout.cshtml # Layout master
│       └── _ViewStart.cshtml
├── wwwroot/               # Archivos estáticos
│   ├── css/               # Estilos CSS
│   └── js/                # Scripts JavaScript
├── Program.cs             # Archivo de configuración principal
├── YMAL.csproj           # Archivo de proyecto
└── README.md             # Este archivo
```

## Características

- ✅ Interfaz web responsiva con Bootstrap 5
- ✅ Controlador MVC bien estructurado
- ✅ Vistas Razor dinámicas
- ✅ Validación de formularios en servidor
- ✅ Sistema de logging integrado
- ✅ Layout compartido para todas las páginas
- ✅ Estilos CSS personalizados
- ✅ Navegación intuitiva

## Páginas Disponibles

- **Inicio** - Página principal con descripción de la aplicación
- **Acerca de** - Información sobre la aplicación y características
- **Contacto** - Formulario de contacto para enviar mensajes

## Tecnología

- **.NET 8.0** - Framework de desarrollo
- **ASP.NET Core MVC** - Patrón arquitectónico
- **Razor** - Motor de plantillas
- **Bootstrap 5** - Framework CSS
- **HTML5 & CSS3** - Estándares web modernos

## Instalación desde cero

Si deseas crear un nuevo proyecto ASP.NET Core MVC:

```powershell
dotnet new mvc -n YMAL
cd YMAL
dotnet run
```

## Notas de Desarrollo

- La aplicación se ejecuta por defecto en `https://localhost:5001`
- Los cambios en archivos Razor se reflejan automáticamente
- Para debug, utiliza VS Code con la extensión C#

## Autor

Creado como aplicación web básica de demostración en ASP.NET Core MVC
