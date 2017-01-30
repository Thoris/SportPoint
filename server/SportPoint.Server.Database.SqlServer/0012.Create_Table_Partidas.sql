CREATE TABLE [Partidas]
(
	[PartidaId] INT NOT NULL PRIMARY KEY, 
    [DataJogo] DATETIME NULL, 
    [HorarioId] INT NULL,
	[CriadoPor] VARCHAR(20), 
    [DataCriacao] DATETIME NULL, 
    [ModificadoPor] VARCHAR(20) NULL, 
    [DataModificacao] DATETIME NULL, 
    [StatusRegistro] SMALLINT NULL
)
