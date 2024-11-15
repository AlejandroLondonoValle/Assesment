

# <div align="center">Sistema de Gestión de Citas para Clínica</div>


Sistema de gestión de citas para clínicas privadas desarrollado en C# y .NET. Este sistema tiene como objetivo resolver los problemas de programación de citas, disponibilidad de médicos, y el seguimiento del historial de pacientes mediante una API RESTful. La solución elimina conflictos de horario, citas duplicadas y facilita la administración de la clínica.

## Licencia
MIT License

## Índice
- [Descripción](#descripción)
- [Características](#características)
- [Tecnologías](#tecnologías)
- [Instalación](#instalación)
- [Uso](#uso)
- [Contribución](#contribución)
- [Licencia](#licencia)
- [Créditos](#créditos)
- [Contacto](#contacto)

## Descripción
El sistema de gestión de citas para clínica está diseñado para mejorar la eficiencia administrativa en el agendamiento de citas médicas, asegurando que no haya conflictos de horario, evitando duplicación de citas, y facilitando el seguimiento del historial médico de los pacientes. A través de esta API, se permite la interacción de los médicos, pacientes y administradores para gestionar las citas de manera efectiva.

## Características
- **Gestión de Citas**: Permite agendar, reprogramar y cancelar citas con médicos.
- **Control de Disponibilidad**: Asegura que no haya citas duplicadas para el mismo médico en un mismo horario.
- **Historial Médico**: Los médicos y administradores pueden ver el historial de citas de los pacientes.
- **Filtrado de Citas**: Permite filtrar citas por fecha, especialidad y motivo.
- **Notas y Comentarios**: Los usuarios pueden agregar notas a las citas para un mejor seguimiento.
- **Autenticación de Usuarios**: El sistema permite el acceso de diferentes usuarios (médicos, pacientes y administradores) con roles y permisos específicos.

## Tecnologías
- **Lenguajes**: C#
- **Frameworks**: .NET 6.0
- **Base de Datos**: SQL Server
- **ORM**: Entity Framework Core
- **Autenticación**: JWT (JSON Web Tokens)
- **Documentación**: Swagger

## Instalación

### Prerrequisitos
- **.NET SDK**: Asegúrate de tener instalado el SDK de .NET 6.0 o superior.
- **SQL Server**: Debes tener SQL Server instalado y configurado en tu máquina.

### Clonando el Repositorio
```bash
git clone https://github.com/tu_usuario/gestion-citas-clinica.git
```

### Instalando Dependencias
```bash
cd gestion-citas-clinica
dotnet restore
```

### Configuración
1. **Base de Datos**:
   - Crea una base de datos en SQL Server y configura la cadena de conexión en `appsettings.json`.

2. **Migraciones**:
   - Ejecuta las migraciones para crear las tablas en la base de datos:
   ```bash
   dotnet ef database update
   ```

### Ejecución
Para ejecutar la API localmente:
```bash
dotnet run
```
La API estará disponible en `http://localhost:5000`.

## Uso
Para interactuar con la API, puedes usar herramientas como Postman o la interfaz integrada de Swagger. Aquí tienes un ejemplo de cómo hacer una solicitud GET para consultar todas las citas:

```bash
curl -X GET "http://localhost:5000/api/v1/citas"
```

## Contribución
Si deseas contribuir al proyecto, sigue estos pasos:

1. Haz un fork del repositorio.
2. Crea una rama para tu característica:
   ```bash
   git checkout -b feature/nueva-caracteristica
   ```
3. Realiza tus cambios y haz commit:
   ```bash
   git commit -am 'Agregada nueva característica'
   ```
4. Envía la rama:
   ```bash
   git push origin feature/nueva-caracteristica
   ```
5. Crea una pull request en GitHub.

### Código de Conducta
Por favor, sigue el código de conducta establecido para mantener un ambiente colaborativo.

## Licencia
Este proyecto está licenciado bajo la Licencia MIT - consulta el archivo LICENSE para más detalles.

## Créditos
**Autor**: Luis Alejandro Londoño Valle

**Bibliotecas o Recursos**: Agradecimientos a cualquier biblioteca o recurso utilizado en el proyecto.

## Contacto
Luis Alejandro Londoño Valle: [GitHub](https://github.com/AlejandroLondonoValle)

---
