CREATE TABLE [dbo].[Bloques]
(
	[IdBloque] INT NOT NULL identity (0,1) PRIMARY KEY, 
    [Nombre] NVARCHAR(50) NOT NULL, 
    [IdTeatro] INT NOT NULL, 
    CONSTRAINT [FK_Bloques_IdTeatro] FOREIGN KEY ([IdTeatro]) REFERENCES [Teatros]([IdTeatro]) ON DELETE CASCADE ON UPDATE CASCADE,  
)