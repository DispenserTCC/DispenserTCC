USE tcc2023;
CREATE TABLE Usuarios (
	Id INT PRIMARY KEY AUTO_INCREMENT,
	Nome VARCHAR(200),
	NumDocumento VARCHAR(50),
	DatNascimento DATETIME,
	NumTelefone VARCHAR(50),
	Email VARCHAR(200),
	Senha VARCHAR(100)
);