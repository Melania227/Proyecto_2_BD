CREATE TABLE [dbo].[Transacciones]
(
	[NumFactura] INT NOT NULL identity (0,1) PRIMARY KEY, 
    [Nombre] NVARCHAR(50) NOT NULL, 
    [Telefono] INT NOT NULL, 
    [Mail] NVARCHAR(15) NOT NULL, 
    [Fecha] DATE NOT NULL, 
    [Hora] TIME NOT NULL, 
    [TipoTransaccion] NVARCHAR(10) NOT NULL, 
    [NumAprobacion] INT NOT NULL, 
    [NumBoleto] INT NOT NULL, 
    CONSTRAINT [FK_Transacciones_NumBoleto] FOREIGN KEY ([NumBoleto]) REFERENCES [Boletos]([NumBoleto])
)