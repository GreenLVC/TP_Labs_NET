/****** Objeto:  Database [academia]    Fecha de la secuencia de comandos: 08/11/2009 09:53:40 ******/
CREATE DATABASE academia;
go
/****** Objeto:  Table [dbo].[usuarios]    Fecha de la secuencia de comandos: 08/11/2009 09:53:26 ******/
USE ACADEMIA
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usuarios]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo_doc] [int] NULL,
	[nro_doc] [int] NULL,
	[fecha_nac] [datetime] NULL,
	[apellido] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[celular] [varchar](50) NULL,
	[usuario] [varchar](50) NULL,
	[clave] [varchar](50) NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT USUARIOS (tipo_doc, nro_doc, fecha_nac, apellido, nombre, direccion, telefono, email, celular, usuario, clave ) VALUES (1, 11111111, '19111111', 'Juana', 'Perez', 'A la vuelta de la esquina', '111-1111', 'juanaperez@gmail.com', '111-111111', 'jperez', 'clave111')
GO
INSERT USUARIOS (tipo_doc, nro_doc, fecha_nac, apellido, nombre, direccion, telefono, email, celular, usuario, clave ) VALUES (2, 22222222, '19020202', 'Jhon', 'Doe', 'Lejos', '222-2222', 'jhon@doe.com.ar', '222-222222', 'jd', 'jhony')
GO