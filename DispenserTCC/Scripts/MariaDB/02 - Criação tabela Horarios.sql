CREATE TABLE Horarios(
	IdHorario INT PRIMARY KEY,
	IdUsuario INT,
	Medicamento varchar(255),
	Quantidade INT,
	DatPrescricao DATETIME,
	FOREIGN KEY (IdUsuario) REFERENCES Usuarios(Id)
);