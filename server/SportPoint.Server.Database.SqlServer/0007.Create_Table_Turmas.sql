CREATE TABLE Turmas
(
	[TurmaId] INT NOT NULL PRIMARY KEY, 
    [ModalidadeId] INT NULL, 
    [Nome] VARCHAR(50) NULL, 
    [Descricao] VARCHAR(255) NULL,
	[CriadoPor] VARCHAR(20), 
    [DataCriacao] DATETIME NULL, 
    [ModificadoPor] VARCHAR(20) NULL, 
    [DataModificacao] DATETIME NULL, 
    [StatusRegistro] SMALLINT NULL
)
