CREATE TABLE Veterinarios (
    IdVeterinario INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    Telefono NVARCHAR(20),
    Correo NVARCHAR(150),
    Especialidad NVARCHAR(100)
);
