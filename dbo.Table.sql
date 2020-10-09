CREATE TABLE [dbo].[Proveedores]
(
	[IdProveedor] INT NOT NULL PRIMARY KEY,
	[Codigo] CHAR (15) NOT NULL,
	[Nombre] CHAR (70) NOT NULL,
	[NombreEmpresa] CHAR (50) NOT NULL,
	[NombrePropietario] CHAR (50) NOT NULL,
	[Telefono] CHAR (30) NOT NULL,
	[Pais] CHAR (50) NOT NULL,
	[Email] CHAR (50) NOT NULL
)
