CREATE TABLE JogosDatasJogadores
(
	[JogoDataJogadorId] INT NOT NULL PRIMARY KEY, 
    [Login] VARCHAR(50) NULL, 
    [DataJogo] DATETIME NULL, 
    [HorarioId] INT NULL,
	[CriadoPor] VARCHAR(20), 
    [DataCriacao] DATETIME NULL, 
    [ModificadoPor] VARCHAR(20) NULL, 
    [DataModificacao] DATETIME NULL, 
    [StatusRegistro] SMALLINT NULL
)
