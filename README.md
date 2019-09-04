# DatabaseLinq

## Entity FrameworkCore

Instalar dependencias de paquetes para conectarse a la base de datos

Ir al menu **Herramientas** -> **Administrador de paquetes Nuget** -> **Consola de administrador de paquetes** y ejecutar los siguientes comandos:

```sh
dotnet add NOMBRE_PROYECTO package Microsoft.EntityFrameworkCore.Design
dotnet add NOMBRE_PROYECTO package MySql.Data.EntityFrameworkCore
dotnet add NOMBRE_PROYECTO package MySql.Data.EntityFrameworkCore.Design
dotnet add NOMBRE_PROYECTO package Microsoft.EntityFrameworkCore.Tools
```

donde NOMBRE_PROYECTO es el nombre del proyecto C# en el Visual Studio

Realizar scaffolding de la base de datos

Ejecutar el siguiente comando en la **Consola de administrador de paquetes**

```sh
dotnet ef dbcontext scaffold "server=IPSERVIDOR;port=4040;database=NOMBRE_BASEDEDATOS;user=USUARIO;password=CONSTRASENA" "Pomelo.EntityFrameworkCore.MySql" -o .\Models -f --project NOMBRE_PROYECTO --context NOMBRE_CONTEXTO
```

Ejemplo

```sh
dotnet ef dbcontext scaffold "server=localhost;port=4040;database=mundo;user=root;password=telesca1234" "MySql.Data.EntityFrameworkCore" -o .\Models -f --project EjemploLinqDatabase --context MundoDbContext
```
