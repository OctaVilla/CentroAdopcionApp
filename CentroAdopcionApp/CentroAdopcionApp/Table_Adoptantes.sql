CREATE TABLE Adoptantes (
    IdAdoptante INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    Direccion NVARCHAR(200),
    Telefono NVARCHAR(20),
    Correo NVARCHAR(100)
);
