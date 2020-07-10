CREATE TABLE [dbo].[Precio_X_Bloque]
(
	[IdPrecioXBloque] INT NOT NULL identity (0,1) PRIMARY KEY, 
    [Precio] DECIMAL(10, 2) NOT NULL, 
    [IdProduccion] INT NOT NULL, 
    CONSTRAINT [FK_PrecioXBloque_IdProduccion] FOREIGN KEY ([IdProduccion]) REFERENCES [Producciones]([IdProduccion]) ON DELETE CASCADE ON UPDATE CASCADE
)
