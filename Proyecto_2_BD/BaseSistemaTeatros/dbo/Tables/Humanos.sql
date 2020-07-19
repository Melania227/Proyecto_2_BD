CREATE TABLE [dbo].[Humanos]
(
	[Cedula] INT NOT NULL PRIMARY KEY,  
    [Nombre] NVARCHAR(25) NOT NULL, 
    [Apellidos] NVARCHAR(25) NOT NULL, 
    [Correo] NVARCHAR(50) NOT NULL, 
    [Fec_Nacimiento] DATE NOT NULL, 
    [Direccion] NVARCHAR(50) NOT NULL, 
    [Sexo] NVARCHAR NOT NULL, 
    [NumCasa] INT NULL, 
    [NumTelefono] INT NOT NULL, 
    [NumOtro] INT NULL
    )