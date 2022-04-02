# YanbalExamenLT

Para iniciar la solución de la pregunta 3 (DemoWebCoreMVC) es necesario que revisen el archivo appsetting.json para asegurar la conexión a una instancia de sql server válida y con las credenciales válidas, el nombre de la base de datos no importa, el que levanta la aplicación lo define, pero sí es importante asegurar que la cadena conexión sea a una instancia válida de sql server:

<h4>appsettings.json</h4>
...
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=Clientitos;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  ...
