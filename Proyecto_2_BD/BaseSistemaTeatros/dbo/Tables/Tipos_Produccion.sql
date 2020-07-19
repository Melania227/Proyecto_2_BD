CREATE TABLE [dbo].[Tipos_Produccion]
(
	[IdTipoProd] INT NOT NULL identity (0,1) PRIMARY KEY, 
    [Tipo] NVARCHAR(20) NOT NULL UNIQUE
)
