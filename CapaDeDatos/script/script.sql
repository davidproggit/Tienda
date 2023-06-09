USE [Tienda]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Descripcion] [nvarchar](100) NULL,
	[Marca] [nvarchar](100) NULL,
	[Precio] [float] NULL,
	[Stock] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NombreLogin] [nvarchar](100) NOT NULL,
	[Clave] [nvarchar](100) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Cargo] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------EDITAR

create proc [dbo].[EditarProducto]
@nombre nvarchar (100),
@descripcion nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int,
@id int
as
update Productos set Nombre=@nombre, Descripcion=@descripcion, Marca=@marca, Precio=@precio, Stock=@stock where Id=@id
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------ELIMINAR
create proc [dbo].[EliminarProducto]
@idproductoeliminar int
as
delete from Productos where Id=@idproductoeliminar
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------INSERTAR 
create proc [dbo].[InsertarProducto]
@nombre nvarchar (100),
@descripcion nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int
as
insert into Productos values (@nombre,@descripcion,@marca,@precio,@stock)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---PROCEDIMIENTOS ALMACENADOS 
--------------------------MOSTRAR 
CREATE proc [dbo].[MostrarProductos]
as
select Id,Nombre, Descripcion, Marca, Precio, Stock from Productos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UsuarioLeerDatos]
as
select ID, NombreLogin, Clave, Nombre, Apellido, Email, Cargo from Usuarios
GO
