CREATE TABLE [dbo].[Bloques]
(
	[IdBloque] INT NOT NULL PRIMARY KEY, 
    [Nombre] NVARCHAR(50) NOT NULL, 
    [IdTeatro] INT NOT NULL, 
    [IdPrecioXBloque] INT NOT NULL, 
    CONSTRAINT [FK_Bloques_IdTeatro] FOREIGN KEY ([IdTeatro]) REFERENCES [Teatros]([IdTeatro]) ON DELETE CASCADE ON UPDATE CASCADE, 
    CONSTRAINT [FK_Bloques_IdPrecioXBloque] FOREIGN KEY ([IdPrecioXBloque]) REFERENCES [Precio_X_Bloque]([IdPrecioXBloque]) ON DELETE CASCADE ON UPDATE CASCADE
)
