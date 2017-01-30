CREATE TABLE Jogadores
(
	[JogadorId] INT NOT NULL PRIMARY KEY, 
    [Nome] VARCHAR(255) NULL, 
    [DataNascimento] DATE NULL, 
    [Email] VARCHAR(100) NULL, 
    [Telefone] VARCHAR(20) NULL,
	[CriadoPor] VARCHAR(20), 
    [DataCriacao] DATETIME NULL, 
    [ModificadoPor] VARCHAR(20) NULL, 
    [DataModificacao] DATETIME NULL, 
    [StatusRegistro] SMALLINT NULL
)
