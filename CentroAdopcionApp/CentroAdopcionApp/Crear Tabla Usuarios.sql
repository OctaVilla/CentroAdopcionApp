CREATE TABLE Usuarios (
IdUsuario INT PRIMARY KEY IDENTITY,
Username NVARCHAR(50) UNIQUE,
PasswordHash NVARCHAR(64), --para SH256
Rol NVARCHAR(20)
);