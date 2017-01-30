CREATE TABLE Usuarios
(
	[Login] VARCHAR(20) NOT NULL PRIMARY KEY, 
    [Senha] VARCHAR(50) NULL, 
    [Email] VARCHAR(200) NULL, 
    [Telefone] VARCHAR(30) NULL,
	[CriadoPor] VARCHAR(20), 
    [DataCriacao] DATETIME NULL, 
    [ModificadoPor] VARCHAR(20) NULL, 
    [DataModificacao] DATETIME NULL, 
    [StatusRegistro] SMALLINT NULL
)
