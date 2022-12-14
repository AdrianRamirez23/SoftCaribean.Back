USE [SoftCaribean]
GO
/****** Object:  Table [dbo].[DataMaestras]    Script Date: 8/29/2022 5:39:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataMaestras](
	[nmmaestro] [varchar](150) NOT NULL,
	[nmdato] [varchar](150) NOT NULL,
	[cddato] [varchar](20) NOT NULL,
	[cadato1] [varchar](100) NOT NULL,
	[cddato2] [varchar](100) NOT NULL,
	[cddato3] [varchar](100) NOT NULL,
	[feregistro] [timestamp] NOT NULL,
	[febaja] [datetime] NOT NULL,
 CONSTRAINT [PK_DataMaestras] PRIMARY KEY CLUSTERED 
(
	[nmdato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Maestras]    Script Date: 8/29/2022 5:39:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maestras](
	[nmmaestro] [varchar](150) NOT NULL,
	[cdmaestro] [varchar](5) NOT NULL,
	[dsmaestro] [varchar](100) NOT NULL,
	[feregistro] [timestamp] NOT NULL,
	[febaja] [datetime] NOT NULL,
 CONSTRAINT [PK_Maestras] PRIMARY KEY CLUSTERED 
(
	[nmmaestro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 8/29/2022 5:39:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[nmid] [int] NOT NULL,
	[nmid_persona] [int] NULL,
	[nmid_medicotra] [int] NULL,
	[dseps] [varchar](50) NOT NULL,
	[dsarl] [varchar](50) NOT NULL,
	[feregistro] [datetime] NOT NULL,
	[febaja] [datetime] NOT NULL,
	[cduusuario] [varchar](150) NOT NULL,
	[dscondicion] [text] NOT NULL,
 CONSTRAINT [PK_Pacientes] PRIMARY KEY CLUSTERED 
(
	[nmid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 8/29/2022 5:39:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[nmid] [int] IDENTITY(1,1) NOT NULL,
	[cddocumento] [varchar](20) NOT NULL,
	[dsnombres] [varchar](50) NOT NULL,
	[dsapellidos] [varchar](50) NOT NULL,
	[fenacimiento] [date] NOT NULL,
	[cdtipo] [varchar](10) NOT NULL,
	[cdgenero] [varchar](10) NOT NULL,
	[feregistro] [datetime] NOT NULL,
	[febaja] [datetime] NOT NULL,
	[cdusuario] [varchar](150) NULL,
	[dsdireccion] [varchar](200) NOT NULL,
	[dsphoto] [varchar](500) NULL,
	[cdtelfono_fijo] [varchar](20) NOT NULL,
	[cdtelefono_movil] [varchar](20) NOT NULL,
	[dsemail] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[nmid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DataMaestras] ([nmmaestro], [nmdato], [cddato], [cadato1], [cddato2], [cddato3], [febaja]) VALUES (N'01', N'01', N'CC', N'Cedula', N'', N'', CAST(N'2022-08-28T17:13:57.817' AS DateTime))
INSERT [dbo].[DataMaestras] ([nmmaestro], [nmdato], [cddato], [cadato1], [cddato2], [cddato3], [febaja]) VALUES (N'01', N'02', N'NIT', N'NIT', N'', N'', CAST(N'2022-08-28T17:15:05.950' AS DateTime))
INSERT [dbo].[DataMaestras] ([nmmaestro], [nmdato], [cddato], [cadato1], [cddato2], [cddato3], [febaja]) VALUES (N'01', N'03', N'RC', N'Registro Civil', N'', N'', CAST(N'2022-08-28T17:15:24.690' AS DateTime))
INSERT [dbo].[DataMaestras] ([nmmaestro], [nmdato], [cddato], [cadato1], [cddato2], [cddato3], [febaja]) VALUES (N'01', N'04', N'P', N'Pasaporte', N'', N'', CAST(N'2022-08-28T17:15:50.730' AS DateTime))
INSERT [dbo].[DataMaestras] ([nmmaestro], [nmdato], [cddato], [cadato1], [cddato2], [cddato3], [febaja]) VALUES (N'03', N'05', N'M', N'Masculino', N'', N'', CAST(N'2022-08-28T17:16:45.307' AS DateTime))
INSERT [dbo].[DataMaestras] ([nmmaestro], [nmdato], [cddato], [cadato1], [cddato2], [cddato3], [febaja]) VALUES (N'03', N'06', N'F', N'Femenino', N'', N'', CAST(N'2022-08-28T17:17:19.023' AS DateTime))
INSERT [dbo].[DataMaestras] ([nmmaestro], [nmdato], [cddato], [cadato1], [cddato2], [cddato3], [febaja]) VALUES (N'03', N'07', N'O', N'Otro', N'', N'', CAST(N'2022-08-28T17:17:39.373' AS DateTime))
INSERT [dbo].[DataMaestras] ([nmmaestro], [nmdato], [cddato], [cadato1], [cddato2], [cddato3], [febaja]) VALUES (N'02', N'08', N'N', N'Natural', N'', N'', CAST(N'2022-08-28T17:18:23.457' AS DateTime))
INSERT [dbo].[DataMaestras] ([nmmaestro], [nmdato], [cddato], [cadato1], [cddato2], [cddato3], [febaja]) VALUES (N'02', N'09', N'J', N'Juridica', N'', N'', CAST(N'2022-08-28T17:18:38.290' AS DateTime))
INSERT [dbo].[DataMaestras] ([nmmaestro], [nmdato], [cddato], [cadato1], [cddato2], [cddato3], [febaja]) VALUES (N'04', N'10', N'A', N'Administrador', N'', N'', CAST(N'2022-08-28T17:19:19.063' AS DateTime))
INSERT [dbo].[DataMaestras] ([nmmaestro], [nmdato], [cddato], [cadato1], [cddato2], [cddato3], [febaja]) VALUES (N'04', N'11', N'U', N'Usuario', N'', N'', CAST(N'2022-08-28T17:19:33.100' AS DateTime))
INSERT [dbo].[DataMaestras] ([nmmaestro], [nmdato], [cddato], [cadato1], [cddato2], [cddato3], [febaja]) VALUES (N'04', N'12', N'M', N'Medico', N'', N'', CAST(N'2022-08-28T17:19:45.640' AS DateTime))
INSERT [dbo].[DataMaestras] ([nmmaestro], [nmdato], [cddato], [cadato1], [cddato2], [cddato3], [febaja]) VALUES (N'04', N'13', N'I', N'Invitado', N'', N'', CAST(N'2022-08-28T18:51:59.727' AS DateTime))
GO
INSERT [dbo].[Maestras] ([nmmaestro], [cdmaestro], [dsmaestro], [febaja]) VALUES (N'01', N'01', N'cd_documento', CAST(N'2022-08-28T17:06:37.667' AS DateTime))
INSERT [dbo].[Maestras] ([nmmaestro], [cdmaestro], [dsmaestro], [febaja]) VALUES (N'02', N'02', N'cd_persona', CAST(N'2022-08-28T17:06:58.457' AS DateTime))
INSERT [dbo].[Maestras] ([nmmaestro], [cdmaestro], [dsmaestro], [febaja]) VALUES (N'03', N'03', N'cd_genero', CAST(N'2022-08-28T17:07:12.300' AS DateTime))
INSERT [dbo].[Maestras] ([nmmaestro], [cdmaestro], [dsmaestro], [febaja]) VALUES (N'04', N'04', N'cd_usuario', CAST(N'2022-08-28T17:07:27.657' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Personas] ON 

INSERT [dbo].[Personas] ([nmid], [cddocumento], [dsnombres], [dsapellidos], [fenacimiento], [cdtipo], [cdgenero], [feregistro], [febaja], [cdusuario], [dsdireccion], [dsphoto], [cdtelfono_fijo], [cdtelefono_movil], [dsemail]) VALUES (1, N'1036598444', N'ADRIAN ESTEBAN', N'RAMIREZ JIMENEZ', CAST(N'1986-02-05' AS Date), N'N', N'M', CAST(N'2022-08-28T21:01:34.293' AS DateTime), CAST(N'2022-08-28T21:01:34.293' AS DateTime), N'automatico', N'CALLE 79 SUR # 55-15', NULL, N'3014881243', N'3014881243', N'adrian.ramirez23@hotmail.com')
SET IDENTITY_INSERT [dbo].[Personas] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Maestras]    Script Date: 8/29/2022 5:39:58 AM ******/
ALTER TABLE [dbo].[Maestras] ADD  CONSTRAINT [IX_Maestras] UNIQUE NONCLUSTERED 
(
	[nmmaestro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Pacientes]    Script Date: 8/29/2022 5:39:58 AM ******/
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [IX_Pacientes] UNIQUE NONCLUSTERED 
(
	[nmid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Personas]    Script Date: 8/29/2022 5:39:58 AM ******/
ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [IX_Personas] UNIQUE NONCLUSTERED 
(
	[nmid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DataMaestras]  WITH CHECK ADD  CONSTRAINT [FK01_DataMaestra_Maestras] FOREIGN KEY([nmmaestro])
REFERENCES [dbo].[Maestras] ([nmmaestro])
GO
ALTER TABLE [dbo].[DataMaestras] CHECK CONSTRAINT [FK01_DataMaestra_Maestras]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK01_Pacientes_Personas] FOREIGN KEY([nmid_medicotra])
REFERENCES [dbo].[Personas] ([nmid])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK01_Pacientes_Personas]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK02_Pacientes_Personas] FOREIGN KEY([nmid_persona])
REFERENCES [dbo].[Personas] ([nmid])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK02_Pacientes_Personas]
GO
