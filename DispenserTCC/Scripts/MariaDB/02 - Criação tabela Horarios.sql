CREATE TABLE Horarios(
	IdHorario INT NOT NULL AUTO_INCREMENT,
	IdUsuario INT,
	Medicamento varchar(255),
	Quantidade INT,
	DatPrescricao DATETIME,
	Dispensado BIT,
	PRIMARY KEY (IdHorario),
	FOREIGN KEY (IdUsuario) REFERENCES Usuarios(Id)
);