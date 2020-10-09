CREATE TABLE [dbo].[Empleados]
(
	[IdEmpleado] INT NOT NULL PRIMARY KEY,
	[Codigo] CHAR (15) NOT NULL,
	[Nombre] CHAR (70) NOT NULL,
	[Email] CHAR (50) NOT NULL,
	[Telefono] CHAR (15) NOT NULL,
	[Direccion] CHAR (100) NOT NULL,
	[Sueldo] CHAR (30) NOT NULL,
	[PuestoLaboral] CHAR (50) NOT NULL,
	[Horarios] CHAR (50) NOT NULL
)
