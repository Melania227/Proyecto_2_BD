CREATE TABLE [dbo].[Usuarios]
(
	[IdUsuario] INT NOT NULL identity (0,1) PRIMARY KEY,  
    [Usuario] NVARCHAR(15) NOT NULL UNIQUE, 
    [Password] NVARCHAR(164) NOT NULL, 
    [Tipo] INT NOT NULL, 
    [IdTeatro_usuarios] INT NULL, 
    [IdUsuarioHumano] INT NOT NULL UNIQUE,
    CONSTRAINT [FK_Usuarios_Teatro] FOREIGN KEY ([IdTeatro_usuarios]) REFERENCES [Teatros]([IdTeatro]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Humanos_Usuario] FOREIGN KEY ([IdUsuarioHumano]) REFERENCES [Humanos]([Cedula]) ON DELETE CASCADE ON UPDATE CASCADE
)