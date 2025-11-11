CREATE TABLE Adopciones (
    IdAdopcion INT IDENTITY(1,1) PRIMARY KEY,
    IdAdoptante INT,
    IdMascota INT,
    FechaAdopcion DATE,
    Observacion NVARCHAR(300),
    FOREIGN KEY (IdAdoptante) REFERENCES Adoptantes(IdAdoptante),
    FOREIGN KEY (IdMascota) REFERENCES Mascotas(IdMascota)
);
