CREATE TABLE NiveisTecnicos
(
	[ModalidadeId] INT NOT NULL PRIMARY KEY, 
    [Login] VARCHAR(50) NULL,
	[CriadoPor] VARCHAR(20), 
    [DataCriacao] DATETIME NULL, 
    [ModificadoPor] VARCHAR(20) NULL, 
    [DataModificacao] DATETIME NULL, 
    [StatusRegistro] SMALLINT NULL
)
