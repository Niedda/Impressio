USE [foernuft]
GO

/****** Object:  Table [dbo].[SimpleOffset]    Script Date: 13.02.2013 19:54:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[SimpleOffset](
	[SimpleOffsetId] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [varchar](50) NOT NULL,
	[FkSimpleOffsetOrder] [int] NULL,
	[PositionTotal] [int] NULL,
	[IsPredefined] [bit] NOT NULL,
	[ColorFront] [int] NULL,
	[ColorBack] [int] NULL,
	[Pages] [int] NULL,
	[Width] [int] NULL,
	[Height] [int] NULL,
	[Plates] [int] NULL,
	[FkSimpleOffsetMachine] [int] NULL,
	[PrintType] [int] NULL,
	[UsePerVertical] [int] NULL,
	[UsePerHorizontal] [int] NULL,
	[FkSimpleOffsetPaper] [int] NULL,
	[PaperPrice] [int] NULL,
	[PrintFormatHeight] [int] NULL,
	[PrintFormatWidth] [int] NULL,
	[Sheets] [int] NULL,
	[ColorChanges] [int] NULL,
	[PaperAddition] [int] NULL,
 CONSTRAINT [PK_SimpleOffset] PRIMARY KEY CLUSTERED 
(
	[SimpleOffsetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[SimpleOffset]  WITH CHECK ADD  CONSTRAINT [FK_SimpleOffset_Machine] FOREIGN KEY([FkSimpleOffsetMachine])
REFERENCES [dbo].[Machine] ([MachineId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO

ALTER TABLE [dbo].[SimpleOffset] CHECK CONSTRAINT [FK_SimpleOffset_Machine]
GO

ALTER TABLE [dbo].[SimpleOffset]  WITH CHECK ADD  CONSTRAINT [FK_SimpleOffset_Order] FOREIGN KEY([FkSimpleOffsetOrder])
REFERENCES [dbo].[Order] ([OrderId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[SimpleOffset] CHECK CONSTRAINT [FK_SimpleOffset_Order]
GO

ALTER TABLE [dbo].[SimpleOffset]  WITH CHECK ADD  CONSTRAINT [FK_SimpleOffset_Paper] FOREIGN KEY([FkSimpleOffsetPaper])
REFERENCES [dbo].[Paper] ([PaperId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO

ALTER TABLE [dbo].[SimpleOffset] CHECK CONSTRAINT [FK_SimpleOffset_Paper]
GO


