CREATE TABLE [dbo].[Producciones]
(
	[IdProduccion] INT NOT NULL identity (0,1) PRIMARY KEY, 
    [Descripcion] NVARCHAR(200) NOT NULL, 
    [NombrePresentacion] NVARCHAR(50) NOT NULL, 
    [Estado] NVARCHAR(25) NOT NULL DEFAULT 'Confidencial', 
    [FechaInicio] DATE NULL, 
    [FechaFin] DATE NULL, 
    [IdTeatro] INT NOT NULL, 
    [IdTipoProd] INT NOT NULL, 
    [img] NCHAR(10) NULL, 
    CONSTRAINT [FK_Producciones_IdTeatro] FOREIGN KEY ([IdTeatro]) REFERENCES [Teatros](IdTeatro), 
    CONSTRAINT [FK_Producciones_TipoProduccion] FOREIGN KEY ([IdTipoProd]) REFERENCES [Tipos_Produccion]([IdTipoProd]) ON DELETE NO ACTION ON UPDATE CASCADE, 
    )