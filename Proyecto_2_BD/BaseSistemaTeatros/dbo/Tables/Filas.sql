﻿CREATE TABLE [dbo].[Filas]
(
	[IdFila] INT NOT NULL identity (0,1) PRIMARY KEY, 
    [Letra] NVARCHAR NOT NULL, 
    [CantAsientos] INT NOT NULL, 
    [IdBloque] INT NOT NULL, 
    CONSTRAINT [FK_Filas_IdBloques] FOREIGN KEY ([IdBloque]) REFERENCES [Bloques]([IdBloque]) ON DELETE CASCADE ON UPDATE CASCADE
)