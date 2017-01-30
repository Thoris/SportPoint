CREATE TABLE ModalidadesPosicoes
(
	[ModalidadeId] INT NOT NULL , 
    [ModalidadePosicaoId] INT NOT NULL, 
    [Nome] VARCHAR(20) NULL,
	[CriadoPor] VARCHAR(20), 
    [DataCriacao] DATETIME NULL, 
    [ModificadoPor] VARCHAR(20) NULL, 
    [DataModificacao] DATETIME NULL, 
    [StatusRegistro] SMALLINT NULL, 
    PRIMARY KEY ([ModalidadeId], [ModalidadePosicaoId])
)
