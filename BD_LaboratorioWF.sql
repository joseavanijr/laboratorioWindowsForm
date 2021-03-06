CREATE DATABASE [BD_LaboratorioWF]
GO
USE [BD_LaboratorioWF]
GO
/****** Object:  Table [dbo].[Atendimento]    Script Date: 25/10/2016 00:47:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Atendimento](
	[atendimentoID] [int] IDENTITY(1,1) NOT NULL,
	[dataAtendimento] [datetime] NULL,
	[status] [varchar](50) NULL,
	[valorAPagar] [decimal](8,2) NULL,
	[pacienteID] [int] NULL,
 CONSTRAINT [PK_Atendimento_1] PRIMARY KEY CLUSTERED 
(
	[atendimentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Exame]    Script Date: 25/10/2016 00:47:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Exame](
	[exameID] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](50) NULL,
	[valor] [decimal](8,2) NULL,
 CONSTRAINT [PK_Exame_1] PRIMARY KEY CLUSTERED 
(
	[exameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ExamesDoAtendimento]    Script Date: 25/10/2016 00:47:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExamesDoAtendimento](
	[examesDoAtendimentoID] [int] IDENTITY(1,1) NOT NULL,
	[dataExame] [datetime] NULL,
	[status] [varchar](50) NULL,
	[atendimentoID] [int] NOT NULL,
	[exameID] [int] NULL,
 CONSTRAINT [PK_ExamesDoAtendimento_1] PRIMARY KEY CLUSTERED 
(
	[examesDoAtendimentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 25/10/2016 00:47:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paciente](
	[pacienteId] [int] IDENTITY(1,1) NOT NULL,
	[dtnascimento] [datetime] NULL,
	[nome] [varchar](50) NULL,
	[tipoConveniado] [int] NULL,
	[planoDeSaudeID] [int] NULL,
 CONSTRAINT [PK_Paciente_1] PRIMARY KEY CLUSTERED 
(
	[pacienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PlanoDeSaude]    Script Date: 25/10/2016 00:47:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PlanoDeSaude](
	[planoDeSaudeID] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](50) NULL,
 CONSTRAINT [PK_PlanoDeSaude] PRIMARY KEY CLUSTERED 
(
	[planoDeSaudeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Atendimento] ON 

INSERT [dbo].[Atendimento] ([atendimentoID], [dataAtendimento], [status], [valorAPagar], [pacienteID]) VALUES (2, CAST(0x0000A6AA00000000 AS DateTime), N'Atendimento Agendando', 10, 1)
SET IDENTITY_INSERT [dbo].[Atendimento] OFF
SET IDENTITY_INSERT [dbo].[Exame] ON 

INSERT [dbo].[Exame] ([exameID], [descricao], [valor]) VALUES (1, N'Feses', 100)
SET IDENTITY_INSERT [dbo].[Exame] OFF
SET IDENTITY_INSERT [dbo].[ExamesDoAtendimento] ON 

INSERT [dbo].[ExamesDoAtendimento] ([examesDoAtendimentoID], [dataExame], [status], [atendimentoID], [exameID]) VALUES (1, CAST(0x0000A6AA000CDBCD AS DateTime), N'Exame Por fazer', 2, 1)
SET IDENTITY_INSERT [dbo].[ExamesDoAtendimento] OFF
SET IDENTITY_INSERT [dbo].[Paciente] ON 

INSERT [dbo].[Paciente] ([pacienteId], [dtnascimento], [nome], [tipoConveniado], [planoDeSaudeID]) VALUES (1, CAST(0x00009F9800000000 AS DateTime), N'joão', 1, 1)
SET IDENTITY_INSERT [dbo].[Paciente] OFF
SET IDENTITY_INSERT [dbo].[PlanoDeSaude] ON 

INSERT [dbo].[PlanoDeSaude] ([planoDeSaudeID], [descricao]) VALUES (1, N'ASTIR')
INSERT [dbo].[PlanoDeSaude] ([planoDeSaudeID], [descricao]) VALUES (2, N'AMERON')
SET IDENTITY_INSERT [dbo].[PlanoDeSaude] OFF
ALTER TABLE [dbo].[Atendimento]  WITH CHECK ADD  CONSTRAINT [FK_Atendimento_Paciente] FOREIGN KEY([pacienteID])
REFERENCES [dbo].[Paciente] ([pacienteId])
GO
ALTER TABLE [dbo].[Atendimento] CHECK CONSTRAINT [FK_Atendimento_Paciente]
GO
ALTER TABLE [dbo].[ExamesDoAtendimento]  WITH CHECK ADD  CONSTRAINT [FK_ExamesDoAtendimento_Atendimento] FOREIGN KEY([atendimentoID])
REFERENCES [dbo].[Atendimento] ([atendimentoID])
GO
ALTER TABLE [dbo].[ExamesDoAtendimento] CHECK CONSTRAINT [FK_ExamesDoAtendimento_Atendimento]
GO
ALTER TABLE [dbo].[ExamesDoAtendimento]  WITH CHECK ADD  CONSTRAINT [FK_ExamesDoAtendimento_Exame] FOREIGN KEY([exameID])
REFERENCES [dbo].[Exame] ([exameID])
GO
ALTER TABLE [dbo].[ExamesDoAtendimento] CHECK CONSTRAINT [FK_ExamesDoAtendimento_Exame]
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_PlanoDeSaude] FOREIGN KEY([planoDeSaudeID])
REFERENCES [dbo].[PlanoDeSaude] ([planoDeSaudeID])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_PlanoDeSaude]
GO
