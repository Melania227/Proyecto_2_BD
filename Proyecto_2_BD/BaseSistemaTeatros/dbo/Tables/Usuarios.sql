CREATE TABLE [dbo].[Usuarios]
(
	[IdUsuario] INT NOT NULL identity (0,1) PRIMARY KEY,  
    [Usuario] NCHAR(15) NOT NULL, 
    [Password] NCHAR(70) NOT NULL, 
    [Tipo] INT NOT NULL, 
    [IdTeatro_usuarios] INT NOT NULL, 
    [IdUsuarioHumano] INT NOT NULL,
    CONSTRAINT [FK_Usuarios_Teatro] FOREIGN KEY ([IdTeatro_usuarios]) REFERENCES [Teatros]([IdTeatro]),
    CONSTRAINT [FK_Humanos_Usuario] FOREIGN KEY ([IdUsuarioHumano]) REFERENCES [Humanos]([Cedula])
)