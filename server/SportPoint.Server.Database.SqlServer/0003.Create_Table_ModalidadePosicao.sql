CREATE TABLE [ModalidadesPosicoes]
(
	[ModalidadeId] INT NOT NULL , 
    [ModalidadePosicaoId] INT NOT NULL, 
    [Nome] VARCHAR(20) NULL, 
    PRIMARY KEY ([ModalidadeId], [ModalidadePosicaoId])
)
