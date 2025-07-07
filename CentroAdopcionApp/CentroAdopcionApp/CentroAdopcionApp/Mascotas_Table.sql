CREATE TABLE Mascotas (
    IdMascota INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Edad INT,
    Tipo NVARCHAR(50),
    Raza NVARCHAR(50),
    Estado NVARCHAR(50)
);
