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
Integrantes :
ELÍAS ORTIZ, MIGUEL APONTE, OCTAVIO VILLASANTI 
 
1. Introduccion 
Este programa lo desarrollamos para gestionar la adopción de mascotas en un centro de adopción. La idea es tener un sistema de administracion simple pero funcional, donde se pueda registrar y administrar mascotas, aoptantes , voluntarios ,adopciones, veterinarios, y usuarios. Además, tiene seguridad con login y registro de usuarios con contraseña encriptada. 
2. Tecnologias usadas 
-	Lenguaje: C# 
-	Framework:.NET ( Windows Forms para la interfaz gráfica ).
-	Base de datos: SQL Server Express 
-	Seguridad: Contraseñas encriptadas con SHA256 
-	Arquitectura: Manejo por capas (Entidad, Datos, Presentación) para organizar mejor el código.
-	Paradigma de programación orientada a Objetos 
 
3. Funcionalidades principales 
3.1. Login e Inicio de sesión 
-	Los usuarios pueden iniciar sesión con su usuario y contraseña. 
-	La contraseña se guarda en la base de datos de forma segura con hash SHA256. 
-	Solo usuarios registrados pueden entrar al sistema. 

<img width="362" height="434" alt="image" src="https://github.com/user-attachments/assets/47960f15-511d-437c-a577-4b4cc2182acc" />



3.2. Registro de usuarios 
-	Los usuarios nuevos se registran con usuario, contraseña y rol (Administrador, Usuario, Voluntario). 
-	Antes de registrar, el sistema verifica que el usuario no exista. 
-	Contraseñas se guardan hasheadas. 


  <img width="435" height="442" alt="image" src="https://github.com/user-attachments/assets/2ded6e56-85e0-4c17-b496-c13a8869959e" />






  3.3. CRUD de Mascotas 
-	Se puede crear, leer, actualizar y eliminar mascotas. 
-	Cada mascota tiene datos como nombre, tipo, raza, edad, etc. 
<img width="641" height="457" alt="image" src="https://github.com/user-attachments/assets/3f25b333-2deb-4846-a875-2ed4a11747ac" />




3.4. CRUD de Adoptantes 
-Registrar Nuevos Adoptantes 
-Con sus respectivos Datos y que se guarden en la base de datos CentroAdopcionDB 



<img width="759" height="553" alt="image" src="https://github.com/user-attachments/assets/00667051-fe13-41f4-a9b4-71b6a9e89710" />




3. 5. CRUD de Adopciones
 Registro y administración de adopciones realizadas. 
-	Permite asociar un adoptante con una mascota.


<img width="851" height="564" alt="image" src="https://github.com/user-attachments/assets/e91b86ea-5c71-4444-913d-4002d97a1fc7" />

3.6. CRUD de Voluntarios
Cargamos los datos de los Voluntarios  
-Guardamos en la base de datos para posterior consulta 

<img width="916" height="610" alt="image" src="https://github.com/user-attachments/assets/f1743aee-3669-436a-8f77-fa15372c6dc9" />


 
3.7. CRUD de Veterinarios
 Se gestionan los veterinarios que atienden en el centro. 
-	Permite agregar, editar o eliminar datos de veterinarios. 
<img width="772" height="543" alt="image" src="https://github.com/user-attachments/assets/c6ab214b-255f-42cb-abcf-e77487eb2776" />



 
4. Estructura del proyecto 
Capas principales: 
-	Entidad: Clases que representan los datos (Mascotas,Adoptantes,Voluntarios,Usuario,Adopciónes, Veterinario). 
-	Datos: Clases  DAO que se encargan de conectar con la base de datos y ejecutar consultas SQL. 
-	Presentación: Formularios y lógica UI (WinForms). 

5. Seguridad 
-	Las contraseñas nunca se guardan en texto plano, sino que se transforman con SHA256 antes de guardar o comparar. 
-	Esto evita que, en caso de un ataque, las contraseñas estén expuestas. 
6. Como usar el programa 
-	Abrís el programa y aparece la pantalla de login. 
-	Si no tenés usuario, podés crear uno desde el formulario de registro. 
-	Al iniciar sesión, se abre el menú principal con opciones para administrar mascotas, adopciones,veterinarios etc. 
-	En cada módulo podés crear, editar, eliminar registros. 
-	El programa tiene mensajes claros para guiar al usuario. 
7. Mejoras futuras 
-	Agregar reportes y exportación a PDF o Excel. 
-	Implementar roles con permisos más detallados. 
-	Mejorar la interfaz con temas y estilos modernos. 
-	Añadir notificaciones o recordatorios para vacunas o citas. 
8. Consideraciones técnicas 
-	La base de datos se conecta usando SQL Server Express instalado localmente. 
-	La cadena de conexión está en cada formulario que accede a datos. 
-	Se recomienda manejar la cadena de conexión desde un archivo de configuración para facilitar cambiosfuturos. 

 9. Conclusión 
Este proyecto nos a permitió practicar: 
-	Programación con C# y WinForms con el paradigma de programación Orientada a objetos. 
-	Conexión y consultas a base de datos SQL Server. 
-	Seguridad básica con hash de contraseñas. 
-	Organización del código con capas. 
-	Creación de interfaces amigables para el usuario.
  
Ventana de Acerca del Programa


<img width="767" height="431" alt="image" src="https://github.com/user-attachments/assets/441a4a6c-ae26-4e36-9733-350fd512b646" />

