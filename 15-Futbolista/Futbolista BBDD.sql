CREATE DATABASE Futbolista

GO
USE Futbolista
GO

--DROP DATABASE Futbolista
CREATE TABLE Equipos (
ID INT NOT NULL IDENTITY,
Nombre VARCHAR(40) NOT NULL,
AnhoFundacion INT NULL,

CONSTRAINT PK_Equipos PRIMARY KEY (ID))

CREATE TABLE Jugadores (
ID INT NOT NULL IDENTITY,
Nombre VARCHAR(40) NOT NULL,
Apellidos VARCHAR(40) NOT NULL,
Dorsal INT NOT NULL,
Alias VARCHAR(40) NULL,
Posicion VARCHAR (20) NOT NULL,
IDEquipo INT NOT NULL,

CONSTRAINT PK_Jugadores PRIMARY KEY (ID),
CONSTRAINT FK_Jugadores_Equipos FOREIGN KEY (IDEquipo) REFERENCES Equipos(ID) ON DELETE NO ACTION ON UPDATE CASCADE)

INSERT INTO Equipos 
VALUES ('Sevilla', 1905),
	   ('Barcelona', 1899),
	   ('Real Madrid', 1902),
	   ('Atletico Madrid', 1903),
	   ('Valencia', 1919),
	   ('Real Betis',1907)

INSERT INTO Jugadores
VALUES ('Lionel', 'Messi', 10, NULL, 'Delantero', 2),
	   ('Luis', 'Suarez', 9, NULL, 'Delantero', 2),
	   ('Santiago', 'Arias', 4, NULL, 'Defensa', 4),
	   ('Alvaro', 'Morata', 9, NULL, 'Delantero', 4),
	   ('Sergio', 'Canales', 10, NULL, 'Centrocampista', 6),
	   ('Borja', 'Iglesias', 9, NULL, 'Delantero', 6),
	   ('Marcelo', 'Vieira', 12, NULL, 'Defensa', 3),
	   ('Marco', 'Asensio', 20, NULL, 'Centrocampista', 3),
	   ('Tomas', 'Vaclik', 1, NULL, 'Portero', 1),
	   ('Manuel', 'Agudo', 8, 'Nolito', 'Delantero', 1),
	   ('Jose', 'Gaya', 14, NULL, 'Defensa', 5),
	   ('Ezequiel', 'Garay', 24, NULL , 'Defensa', 5)

