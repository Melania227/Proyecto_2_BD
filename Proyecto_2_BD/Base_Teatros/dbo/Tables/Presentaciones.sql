CREATE TABLE [dbo].[Presentaciones]
(
	[IdPresentacion] INT NOT NULL identity (0,1) PRIMARY KEY, 
    [Fecha] DATE NOT NULL, 
    [Hora] TIME NOT NULL, 
    [IdProduccion] INT NOT NULL, 
    CONSTRAINT [FK_Presentaciones_IdProduccion] FOREIGN KEY ([IdProduccion]) REFERENCES [Producciones]([IdProduccion]) ON DELETE CASCADE ON UPDATE CASCADE
)
