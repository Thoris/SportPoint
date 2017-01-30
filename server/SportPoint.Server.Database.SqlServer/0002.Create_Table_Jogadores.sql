CREATE TABLE [dbo].[Jogadores]
(
	[JogadorId] INT NOT NULL PRIMARY KEY, 
    [Nome] VARCHAR(255) NULL, 
    [Senha] VARCHAR(30) NULL, 
    [DataNascimento] DATE NULL, 
    [Email] VARCHAR(100) NULL, 
    [Telefone] VARCHAR(20) NULL
)
