CREATE TABLE Animales (
    IdAnimal INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(50),
    Edad INT,
    TipoAnimal NVARCHAR(30),
    Raza NVARCHAR(30),
    FechaIngreso DATE,
    EstadoAdopcion NVARCHAR(20)
);
