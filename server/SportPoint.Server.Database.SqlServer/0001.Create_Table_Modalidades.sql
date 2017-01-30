CREATE TABLE [dbo].[Modalidades] (
    [ModalidadeId]    INT           NOT NULL IDENTITY(1,1),
    [Nome]            VARCHAR (20)  NULL,
    [Descricao]       VARCHAR (255) NULL,
    [QtdPessoasTime]  SMALLINT      NULL,
    [CriadoPor]       VARCHAR (20)  NULL,
    [DataCriacao]     DATETIME2 (7) NULL,
    [ModificadoPor]   VARCHAR (20)  NULL,
    [DataModificacao] DATETIME2 (7) NULL,
    [StatusRegistro]  SMALLINT      NULL,
    PRIMARY KEY CLUSTERED ([ModalidadeId] ASC)
);

