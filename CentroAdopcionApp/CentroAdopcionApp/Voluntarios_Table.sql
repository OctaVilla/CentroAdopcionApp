CREATE TABLE Voluntarios (
    IdVoluntario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    Direccion NVARCHAR(200),
    Telefono NVARCHAR(20),
    Correo NVARCHAR(100),
    Sucursal NVARCHAR(100)
);
