CREATE TABLE [dbo].[Producciones]
(
	[IdProduccion] INT NOT NULL identity (0,1) PRIMARY KEY, 
    [Descripcion] NVARCHAR(100) NOT NULL, 
    [NombrePresentacion] NVARCHAR(50) NOT NULL, 
    [Estado] NVARCHAR(10) NOT NULL, 
    [FechaInicio] DATE NOT NULL, 
    [FechaFin] DATE NOT NULL, 
    [IdTeatro] INT NOT NULL, 
    [IdTipoProd] INT NOT NULL, 
    CONSTRAINT [FK_Producciones_IdTeatro] FOREIGN KEY ([IdTeatro]) REFERENCES [Teatros](IdTeatro) ON DELETE CASCADE ON UPDATE CASCADE, 
    CONSTRAINT [FK_Producciones_TipoProduccion] FOREIGN KEY ([IdTipoProd]) REFERENCES [Tipos_Produccion]([IdTipoProd]) ON DELETE CASCADE ON UPDATE CASCADE
)
