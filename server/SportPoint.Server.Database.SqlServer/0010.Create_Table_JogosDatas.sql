CREATE TABLE JogosDatas
(
	[DataJogo] DATETIME NOT NULL PRIMARY KEY, 
    [HorarioId] INT NULL,
	[CriadoPor] VARCHAR(20), 
    [DataCriacao] DATETIME NULL, 
    [ModificadoPor] VARCHAR(20) NULL, 
    [DataModificacao] DATETIME NULL, 
    [StatusRegistro] SMALLINT NULL
)
