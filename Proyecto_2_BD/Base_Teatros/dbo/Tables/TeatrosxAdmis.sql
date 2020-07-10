CREATE TABLE [dbo].[TeatrosxAdmis]
(
	[IdUsuario_X] INT NOT NULL, 
    [IdTeatro_X] INT NOT NULL,
    CONSTRAINT [PK_ID] PRIMARY KEY ([IdUsuario_X],[IdTeatro_X]),
    CONSTRAINT [FK_Teatros_Admis_Usuarios] FOREIGN KEY ([IdUsuario_X]) REFERENCES [Teatros]([IdTeatro]) ON DELETE CASCADE ON UPDATE CASCADE, 
    CONSTRAINT [FK_Teatros_Admis_Teatros] FOREIGN KEY ([IdTeatro_X]) REFERENCES [Usuarios]([IdUsuario]) ON DELETE CASCADE ON UPDATE CASCADE
)
