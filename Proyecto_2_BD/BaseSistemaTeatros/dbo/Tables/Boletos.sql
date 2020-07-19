CREATE TABLE [dbo].[Boletos]
(
	[NumBoleto] INT NOT NULL identity (0,1) PRIMARY KEY, 
    [IdFila] INT NOT NULL, 
    [IdPresentacion] INT NOT NULL, 
    [IdPrecioXBloque] INT NOT NULL, 
    [NumAsiento] INT NOT NULL, 
    CONSTRAINT [FK_Boletos_IdFila] FOREIGN KEY ([IdFila]) REFERENCES [Filas]([IdFila]) ON DELETE NO ACTION ON UPDATE CASCADE, 
    CONSTRAINT [FK_Boletos_IdPresentacion] FOREIGN KEY ([IdPresentacion]) REFERENCES [Presentaciones]([IdPresentacion]) ON DELETE NO ACTION ON UPDATE CASCADE,
    CONSTRAINT [FK_Boletos_IdPrecioXBloque] FOREIGN KEY ([IdPrecioXBloque]) REFERENCES [Precio_X_Bloque]([IdPrecioXBloque]) ON DELETE NO ACTION ON UPDATE NO ACTION
)
