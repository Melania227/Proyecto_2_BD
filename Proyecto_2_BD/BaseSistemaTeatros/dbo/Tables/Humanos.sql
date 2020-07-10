CREATE TABLE [dbo].[Humanos]
(
	[Cedula] INT NOT NULL PRIMARY KEY,  
    [Nombre] NCHAR(10) NOT NULL, 
    [Apellidos] NCHAR(25) NOT NULL, 
    [Correo] NCHAR(30) NOT NULL, 
    [Fec.Nacimiento] DATE NOT NULL, 
    [Direccion] NCHAR(25) NOT NULL, 
    [Sexo] NCHAR(10) NOT NULL, 
    [NumCasa] INT NULL, 
    [NumTelefono] INT NOT NULL, 
    [NumOtro] INT NULL
    )