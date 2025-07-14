 Paso a paso para tener el proyecto en tu PC

### 1. Clonar el repositorio

#### Opción A – Desde Visual Studio
1. Abrí Visual Studio
2. Elegí “Clonar un repositorio”
3. Pegá este link:
https://github.com/OctaVilla/CentroAdopcionApp.git
4. Seleccioná la carpeta de destino
5. Visual Studio va a clonar y abrir el proyecto automáticamente.

 Antes de hacer cualquier modificación:
 git pull

 Después de trabajar y guardar tus archivos:

git add .
git commit -m "Comentario"
git push


Centro Adopción 💻📚
PROGRAMA DE WINDOWS FORM 
ELÍAS ORTIZ, MIGUEL APONTE, OCTAVIO VILLASANTI 
 
1. Introduccion 
Este programa lo desarrollamos para gestionar la adopción de mascotas en un centro de adopción. La idea es tener un sistema de administracion simple pero funcional, donde se pueda registrar y administrar mascotas, aoptantes , voluntarios ,adopciones, veterinarios, y usuarios. Además, tiene seguridad con login y registro de usuarios con contraseña encriptada. 
2. Tecnologias usadas 
-	Lenguaje: C# 
-	Framework: Windows Forms para la interfaz gráfica 
-	Base de datos: SQL Server Express 
-	Seguridad: Contraseñas encriptadas con SHA256 
-	Arquitectura: Manejo por capas (Entidad, Datos, Presentación) para organizar mejor el código.
-	Paradigma de programación orientada a Objetos 
 
3. Funcionalidades principales 
3.1. Login e Inicio de sesión 
-	Los usuarios pueden iniciar sesión con su usuario y contraseña. 
-	La contraseña se guarda en la base de datos de forma segura con hash SHA256. 
-	Solo usuarios registrados pueden entrar al sistema. 

  
