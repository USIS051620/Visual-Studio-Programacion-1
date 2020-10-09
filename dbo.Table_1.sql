CREATE TABLE [dbo].[Productos]
(
	[IdProducto] INT NOT NULL PRIMARY KEY,
	[Codigo] CHAR (15) NOT NULL,
	[Nombre] CHAR (50) NOT NULL,
	[Marca] CHAR (30) NOT NULL,
	[Descripcion] CHAR (100) NOT NULL,
	[Precio] CHAR (50) NOT NULL,
	[Cantidad] CHAR (30) NOT NULL
)
