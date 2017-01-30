CREATE TABLE Horarios
(
	[HorarioId] INT NOT NULL PRIMARY KEY, 
    [TurmaJogadorId] INT NULL, 
    [Nome] VARCHAR(20) NULL,
	[CriadoPor] VARCHAR(20), 
    [DataCriacao] DATETIME NULL, 
    [ModificadoPor] VARCHAR(20) NULL, 
    [DataModificacao] DATETIME NULL, 
    [StatusRegistro] SMALLINT NULL
)
