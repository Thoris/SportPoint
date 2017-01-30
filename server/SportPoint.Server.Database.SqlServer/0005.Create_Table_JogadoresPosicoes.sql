
CREATE TABLE JogadoresPosicoes
(
	[ModalidadePosicaoId] INT NOT NULL PRIMARY KEY,
	[ModalidadeId] INT NOT NULL ,
	[Login] varchar(50) NOT NULL ,
	[CriadoPor] VARCHAR(20), 
    [DataCriacao] DATETIME NULL, 
    [ModificadoPor] VARCHAR(20) NULL, 
    [DataModificacao] DATETIME NULL, 
    [StatusRegistro] SMALLINT NULL

)
