CREATE TABLE [dbo].[Teatros]
(
	[IdTeatro] INT NOT NULL identity (0,1) PRIMARY KEY, 
    [Nombre] NVARCHAR(50) NOT NULL, 
    [TelServicioCliente] INT NOT NULL, 
    [TelTeatro] INT NOT NULL, 
    [TelBoletaria] INT NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [LinkWeb] NVARCHAR(50) NOT NULL
)