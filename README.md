# 🌟 Sistema Gestor Escolar (SGE)

¡Bienvenido al **Sistema Gestor Escolar (SGE)**! Este proyecto, desarrollado en **.NET 8**, combina el poder del **Domain-Driven Design (DDD)** con la elegante arquitectura **Onion** para ofrecer una solución escolar moderna, escalable y súper eficiente. Gestiona estudiantes, profesores, cursos y más con un código limpio y una estructura que hará que cualquier desarrollador diga: _¡qué chido!_

---

## 📝 Descripción del Proyecto

El **SGE** es un sistema diseñado para simplificar la administración escolar, desde el registro de estudiantes hasta la generación de reportes académicos. Usamos **DDD** para modelar el dominio educativo como se debe, y la **arquitectura Onion** asegura que todo esté bien organizado, con la lógica de negocio en el centro y las dependencias fluyendo hacia adentro. ¿El resultado? Un sistema robusto, testeable y listo para crecer.

---

## 🛠 Tecnologías Utilizadas

- **.NET 8**: El framework más reciente y poderoso.
- **C#**: Nuestro lenguaje estrella.
- **Entity Framework Core**: ORM para manejar la base de datos con estilo.
- **Dapper**: Micro-ORM ligero para consultas rápidas como el viento.
- **SQL Server**: Donde guardamos toda la magia escolar.
- **xUnit**: Pruebas unitarias para que todo funcione perfecto.
- **Dependency Injection**: Inyección de dependencias nativa, porque nos gusta lo elegante.

---

## 🏗 Estructura del Proyecto

El proyecto está organizado con la **arquitectura Onion**, dividida en capas concéntricas:

### 1. **Domain (Dominio)**

- Entidades como Estudiante, Profesor, Curso y Calificación.
- Lógica de negocio pura, sin dependencias externas. ¡El corazón del sistema! ❤️

### 2. **Application (Aplicación)**

- Casos de uso como registrar estudiantes o asignar cursos.
- DTOs, comandos y consultas para mantener todo ordenado.

### 3. **Infrastructure (Infraestructura)**

- Repositorios genéricos con **Dapper** y **EF Core** para acceso a datos.
- Servicios externos (ej. envío de correos) y configuraciones.

### 4. **Presentation (Presentación)**

- **API REST** con controladores genéricos para exponer la funcionalidad.
- Interfaz limpia y lista para conectar con frontends.

---

## ✨ Características Especiales

- **Repositorio Genérico**: Una base reusable para todas las entidades.
- **Controlador Genérico**: Menos código repetitivo, más tiempo para tacos.
- **Servicios**: Lógica encapsulada para operaciones específicas.

---

## 👥 Equipo de Desarrollo

Conoce al equipo que dio vida a este proyecto:

| Nombre                         | Matrícula | Rol              |
| ------------------------------ | --------- | ---------------- |
| Juan de Dios Salmerón Rivera   | 22393224  | Líder del equipo |
| William Joel Chávez López      | 20393144  | Desarrollador    |
| Gabriel David Lizama Gómez     | 22393278  | Desarrollador    |
| Saúl García López              | 21393194  | Desarrollador    |
| Francisco Emmanuel Rojas Cerón | 22393186  | Desarrollador    |

---

## 🚀 Instalación y Configuración

### 📋 Prerrequisitos

- **.NET 8 SDK**
- **Visual Studio 2022** (o tu IDE favorito)
- **SQL Server**

### ⚙ Pasos para Ejecutar

1. Clona este repo tan chido:

   ```bash
   git clone https://github.com/JuanSSalmeron/SGE-Back
   ```

2. Entra al directorio:

   ```bash
   cd SGE
   ```

3. Restaura las dependencias:

   ```bash
   dotnet restore
   ```

4. Configura la conexión en `appsettings.json`:

   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=<tu-servidor>;Database=SGE;Trusted_Connection=True;"
   }
   ```

5. Aplica las migraciones:

   ```bash
   dotnet ef database update
   ```

6. ¡Corre el proyecto y a disfrutar!
   ```bash
   dotnet run --project Backend-Base\Base.API.csproj
   ```

---

## 🎮 Uso del Proyecto

Arranca el sistema y accede en `https://localhost:<puerto>`. Usa la **API** para gestionar todo lo escolar.

### 🌐 Ejemplo de Endpoints

- **GET /api/estudiantes**: Lista de estudiantes.
- **POST /api/estudiantes**: Registra un nuevo estudiante.
- **GET /api/cursos**: Todos los cursos disponibles.
- **PUT /api/calificaciones**: Actualiza calificaciones como pro.

---

## ✅ Funcionalidades Principales

- **Gestión de Estudiantes**: Altas, bajas y cambios.
- **Gestión de Profesores**: Todo sobre los docentes.
- **Gestión de Cursos**: Crea y asigna cursos fácilmente.
- **Reportes**: Genera reportes académicos al instante.

---

## 🤝 Contribuciones

¡Queremos que te unas al equipo! Para contribuir:

1. Haz un fork del repo.
2. Crea tu rama (git checkout -b feature/algo-chido).
3. Commita tus cambios (git commit -m "Añadí algo genial").
4. Sube tu rama (git push origin feature/algo-chido).
5. Abre un **Pull Request** y listo.

---

## 📜 Licencia

Bajo la **Licencia MIT** - ¡úsalo como quieras!

---

## 📧 Contacto

¿Dudas? Escribe al líder del equipo:

**Francisco Emmanuel Rojas Cerón**  
Email: [erojas@ozelot.it](mailto:erojas@ozelot.it)
