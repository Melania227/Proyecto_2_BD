CREATE TABLE [dbo].[Boletos]
(
	[NumBoleto] INT NOT NULL identity (0,1) PRIMARY KEY, 
    [IdFila] INT NOT NULL, 
    [IdPresentacion] INT NOT NULL, 
    [IdPrecioXBloque] INT NOT NULL, 
    CONSTRAINT [FK_Boletos_IdFila] FOREIGN KEY ([IdFila]) REFERENCES [Filas]([IdFila]), 
    CONSTRAINT [FK_Boletos_IdPresentacion] FOREIGN KEY ([IdPresentacion]) REFERENCES [Presentaciones]([IdPresentacion]), 
    CONSTRAINT [FK_Boletos_IdPrecioXBloque] FOREIGN KEY ([IdPrecioXBloque]) REFERENCES [Precio_X_Bloque]([IdPrecioXBloque])
)
