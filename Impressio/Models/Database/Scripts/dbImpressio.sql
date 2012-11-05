USE [foernuft]
GO
/****** Object:  User [user]    Script Date: 26.10.2012 14:55:35 ******/
CREATE USER [user] FOR LOGIN [user] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [user]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [user]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Address](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[FkAddressCompany] [int] NOT NULL,
	[Street] [varchar](50) NOT NULL,
	[StreetNumber] [varchar](20) NULL,
	[City] [varchar](50) NOT NULL,
	[ZipCode] [varchar](20) NULL,
	[Addition] [varchar](50) NULL,
 CONSTRAINT [Address_PK] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ClickCost]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ClickCost](
	[ClickCostId] [int] IDENTITY(1,1) NOT NULL,
	[ClickCost] [float] NOT NULL,
	[ClickName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ClickCost] PRIMARY KEY CLUSTERED 
(
	[ClickCostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Client]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Client](
	[ClientId] [int] IDENTITY(1,1) NOT NULL,
	[FkClientCompany] [int] NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NOT NULL,
	[Phone] [varchar](30) NULL,
	[Mobile] [varchar](30) NULL,
	[Mail] [varchar](50) NULL,
	[Remark] [varchar](max) NULL,
	[FkClientGender] [int] NOT NULL,
 CONSTRAINT [Client_PK] PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Company]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Company](
	[CompanyId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
	[Addition] [varchar](50) NULL,
	[Remark] [varchar](max) NULL,
 CONSTRAINT [Company_PK] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Data]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Data](
	[DataId] [int] IDENTITY(1,1) NOT NULL,
	[FkDataOrder] [int] NOT NULL,
	[PositionName] [varchar](50) NOT NULL,
	[PositionTotal] [int] NOT NULL,
	[Remark] [varchar](max) NULL,
	[IsPredefined] [bit] NOT NULL,
 CONSTRAINT [Data_PK] PRIMARY KEY CLUSTERED 
(
	[DataId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DataPosition]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DataPosition](
	[DataPositionId] [int] IDENTITY(1,1) NOT NULL,
	[FkDataDataPosition] [int] NULL,
	[Description] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[PricePerQuantity] [int] NOT NULL,
	[PriceTotal] [int] NOT NULL,
	[IsPredefined] [bit] NOT NULL,
 CONSTRAINT [DataPosition_PK] PRIMARY KEY CLUSTERED 
(
	[DataPositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Delivery]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Delivery](
	[DeliveryId] [int] IDENTITY(1,1) NOT NULL,
	[FkDeliveryOrder] [int] NOT NULL,
	[FkDeliveryAddress] [int] NULL,
	[FkDeliveryClient] [int] NULL,
	[DeliveryDate] [varchar](20) NOT NULL,
	[FkDeliveryCompany] [int] NOT NULL,
 CONSTRAINT [Delivery_PK] PRIMARY KEY CLUSTERED 
(
	[DeliveryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DeliveryPosition]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DeliveryPosition](
	[DeliveryPositionId] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [int] NOT NULL,
	[DeliveryPosition] [varchar](150) NOT NULL,
	[FkDeliveryPositionDelivery] [int] NOT NULL,
 CONSTRAINT [PK_DeliveryPosition] PRIMARY KEY CLUSTERED 
(
	[DeliveryPositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Description]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Description](
	[DescriptionId] [int] IDENTITY(1,1) NOT NULL,
	[FkDescriptionOrder] [int] NULL,
	[JobTitle] [varchar](50) NOT NULL,
	[Arrange] [int] NOT NULL,
	[IsPredefined] [bit] NOT NULL,
	[Price] [int] NULL,
 CONSTRAINT [Description_PK] PRIMARY KEY CLUSTERED 
(
	[DescriptionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detail]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detail](
	[DetailId] [int] IDENTITY(1,1) NOT NULL,
	[FkDetailDescription] [int] NOT NULL,
	[DetailContent] [varchar](max) NOT NULL,
	[Arrange] [int] NOT NULL,
	[DetailTitle] [varchar](50) NOT NULL,
 CONSTRAINT [Detail_PK] PRIMARY KEY CLUSTERED 
(
	[DetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Finish]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Finish](
	[FinishId] [int] IDENTITY(1,1) NOT NULL,
	[FkFinishOrder] [int] NOT NULL,
	[PositionName] [varchar](50) NOT NULL,
	[PositionTotal] [int] NOT NULL,
	[Remark] [varchar](max) NULL,
	[IsPredefined] [bit] NOT NULL,
 CONSTRAINT [Finish_PK] PRIMARY KEY CLUSTERED 
(
	[FinishId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FinishPosition]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FinishPosition](
	[FinishPositionId] [int] IDENTITY(1,1) NOT NULL,
	[FkFinishFinishPosition] [int] NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[PricePerQuantity] [int] NOT NULL,
	[PriceTotal] [int] NOT NULL,
	[IsPredefined] [bit] NOT NULL,
 CONSTRAINT [FinishPosition_PK] PRIMARY KEY CLUSTERED 
(
	[FinishPositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gender](
	[GenderId] [int] IDENTITY(1,1) NOT NULL,
	[Gender] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[GenderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Machine]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Machine](
	[MachineId] [int] IDENTITY(1,1) NOT NULL,
	[PricePerColor] [int] NOT NULL,
	[Speed] [int] NOT NULL,
	[CostPerHour] [int] NOT NULL,
	[PlateCost] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Machine] PRIMARY KEY CLUSTERED 
(
	[MachineId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Offset]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Offset](
	[OffsetId] [int] IDENTITY(1,1) NOT NULL,
	[FkOffsetPaper] [int] NULL,
	[PaperPricePer] [int] NULL,
	[PaperAddition] [int] NULL,
	[PaperQuantity] [int] NULL,
	[PaperUsePer] [int] NULL,
	[FkOffsetMachine] [int] NULL,
	[PrintType] [int] NULL,
	[ColorAmount] [int] NULL,
	[OffsetQuantity] [int] NULL,
	[PositionTotal] [int] NULL,
	[FkOffsetOrder] [int] NULL,
	[PositionName] [varchar](50) NOT NULL,
	[PrintQuantity] [int] NULL,
 CONSTRAINT [PK_Offset] PRIMARY KEY CLUSTERED 
(
	[OffsetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[FkOrderCompany] [int] NOT NULL,
	[OrderName] [varchar](50) NOT NULL,
	[DateCreated] [varchar](10) NOT NULL,
	[UserCreated] [varchar](20) NOT NULL,
	[DateModified] [varchar](10) NOT NULL,
	[UserModified] [varchar](20) NULL,
	[IsPredefined] [bit] NULL,
	[FkOrderClient] [int] NULL,
	[FkOrderAddress] [int] NULL,
	[FkOrderState] [int] NOT NULL,
	[FolderPath] [varchar](150) NULL,
 CONSTRAINT [Order_PK] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Paper]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paper](
	[PaperId] [int] IDENTITY(1,1) NOT NULL,
	[ItemNumber] [int] NULL,
	[PaperName] [varchar](max) NOT NULL,
	[Vendor] [varchar](50) NULL,
	[Price1] [int] NOT NULL,
	[Price2] [int] NULL,
	[Price3] [int] NULL,
	[Price4] [int] NULL,
	[Amount1] [int] NULL,
	[Amount2] [int] NULL,
	[Amount3] [int] NULL,
	[Direction] [int] NULL,
	[SizeB] [int] NOT NULL,
	[SizeL] [int] NOT NULL,
	[Weight] [int] NOT NULL,
 CONSTRAINT [Paper_PK] PRIMARY KEY CLUSTERED 
(
	[PaperId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Print]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Print](
	[PrintId] [int] IDENTITY(1,1) NOT NULL,
	[FkPrintOrder] [int] NOT NULL,
	[FkPrintPaper] [int] NULL,
	[FkPrintClickCost] [int] NULL,
	[PaperAmount] [int] NULL,
	[PaperAddition] [int] NULL,
	[PrintAmount] [int] NULL,
	[PrintAddition] [int] NULL,
	[PositionName] [varchar](50) NOT NULL,
	[PositionTotal] [int] NOT NULL,
	[IsPredefined] [bit] NOT NULL,
	[PaperPrice] [int] NULL,
	[PaperUsePer] [int] NULL,
	[PrintType] [int] NULL,
 CONSTRAINT [Print_PK] PRIMARY KEY CLUSTERED 
(
	[PrintId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[State]    Script Date: 26.10.2012 14:55:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[State](
	[StateId] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[StateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Data] ADD  CONSTRAINT [DF_Data_IsPredefined]  DEFAULT ((0)) FOR [IsPredefined]
GO
ALTER TABLE [dbo].[DataPosition] ADD  CONSTRAINT [DF_DataPosition_IsPredefined]  DEFAULT ((0)) FOR [IsPredefined]
GO
ALTER TABLE [dbo].[Description] ADD  CONSTRAINT [DF_Description_IsPredefined]  DEFAULT ((0)) FOR [IsPredefined]
GO
ALTER TABLE [dbo].[Finish] ADD  CONSTRAINT [DF_Finish_IsPredefined]  DEFAULT ((0)) FOR [IsPredefined]
GO
ALTER TABLE [dbo].[FinishPosition] ADD  CONSTRAINT [DF_FinishPosition_IsPredefined]  DEFAULT ((0)) FOR [IsPredefined]
GO
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Orders_IsPredefined]  DEFAULT ((0)) FOR [IsPredefined]
GO
ALTER TABLE [dbo].[Print] ADD  CONSTRAINT [DF_Print_PaperAmount]  DEFAULT ((0)) FOR [PaperAmount]
GO
ALTER TABLE [dbo].[Print] ADD  CONSTRAINT [DF_Print_PaperAddition]  DEFAULT ((0)) FOR [PaperAddition]
GO
ALTER TABLE [dbo].[Print] ADD  CONSTRAINT [DF_Print_PrintAmount]  DEFAULT ((0)) FOR [PrintAmount]
GO
ALTER TABLE [dbo].[Print] ADD  CONSTRAINT [DF_Print_PrintAddition]  DEFAULT ((0)) FOR [PrintAddition]
GO
ALTER TABLE [dbo].[Print] ADD  CONSTRAINT [DF_Print_IsPredefined]  DEFAULT ((0)) FOR [IsPredefined]
GO
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [Company_Address_FK1] FOREIGN KEY([FkAddressCompany])
REFERENCES [dbo].[Company] ([CompanyId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [Company_Address_FK1]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [Company_Client_FK1] FOREIGN KEY([FkClientCompany])
REFERENCES [dbo].[Company] ([CompanyId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [Company_Client_FK1]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Gender] FOREIGN KEY([FkClientGender])
REFERENCES [dbo].[Gender] ([GenderId])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Gender]
GO
ALTER TABLE [dbo].[Data]  WITH CHECK ADD  CONSTRAINT [Order_Data_FK1] FOREIGN KEY([FkDataOrder])
REFERENCES [dbo].[Order] ([OrderId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Data] CHECK CONSTRAINT [Order_Data_FK1]
GO
ALTER TABLE [dbo].[DataPosition]  WITH CHECK ADD  CONSTRAINT [Data_DataPosition_FK1] FOREIGN KEY([FkDataDataPosition])
REFERENCES [dbo].[Data] ([DataId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DataPosition] CHECK CONSTRAINT [Data_DataPosition_FK1]
GO
ALTER TABLE [dbo].[Delivery]  WITH CHECK ADD  CONSTRAINT [FK_Delivery_Company] FOREIGN KEY([FkDeliveryCompany])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Delivery] CHECK CONSTRAINT [FK_Delivery_Company]
GO
ALTER TABLE [dbo].[Delivery]  WITH CHECK ADD  CONSTRAINT [Order_Delivery_FK1] FOREIGN KEY([FkDeliveryOrder])
REFERENCES [dbo].[Order] ([OrderId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Delivery] CHECK CONSTRAINT [Order_Delivery_FK1]
GO
ALTER TABLE [dbo].[DeliveryPosition]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryPosition_Delivery] FOREIGN KEY([FkDeliveryPositionDelivery])
REFERENCES [dbo].[Delivery] ([DeliveryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DeliveryPosition] CHECK CONSTRAINT [FK_DeliveryPosition_Delivery]
GO
ALTER TABLE [dbo].[Description]  WITH CHECK ADD  CONSTRAINT [Order_Description_FK1] FOREIGN KEY([FkDescriptionOrder])
REFERENCES [dbo].[Order] ([OrderId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Description] CHECK CONSTRAINT [Order_Description_FK1]
GO
ALTER TABLE [dbo].[Detail]  WITH CHECK ADD  CONSTRAINT [Description_Detail_FK1] FOREIGN KEY([FkDetailDescription])
REFERENCES [dbo].[Description] ([DescriptionId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detail] CHECK CONSTRAINT [Description_Detail_FK1]
GO
ALTER TABLE [dbo].[Finish]  WITH CHECK ADD  CONSTRAINT [Order_Finish_FK1] FOREIGN KEY([FkFinishOrder])
REFERENCES [dbo].[Order] ([OrderId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Finish] CHECK CONSTRAINT [Order_Finish_FK1]
GO
ALTER TABLE [dbo].[FinishPosition]  WITH CHECK ADD  CONSTRAINT [Finish_FinishPosition_FK1] FOREIGN KEY([FkFinishFinishPosition])
REFERENCES [dbo].[Finish] ([FinishId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FinishPosition] CHECK CONSTRAINT [Finish_FinishPosition_FK1]
GO
ALTER TABLE [dbo].[Offset]  WITH CHECK ADD  CONSTRAINT [FK_Offset_Machine] FOREIGN KEY([FkOffsetMachine])
REFERENCES [dbo].[Machine] ([MachineId])
GO
ALTER TABLE [dbo].[Offset] CHECK CONSTRAINT [FK_Offset_Machine]
GO
ALTER TABLE [dbo].[Offset]  WITH CHECK ADD  CONSTRAINT [FK_Offset_Order] FOREIGN KEY([FkOffsetOrder])
REFERENCES [dbo].[Order] ([OrderId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Offset] CHECK CONSTRAINT [FK_Offset_Order]
GO
ALTER TABLE [dbo].[Offset]  WITH CHECK ADD  CONSTRAINT [FK_Offset_Paper] FOREIGN KEY([FkOffsetPaper])
REFERENCES [dbo].[Paper] ([PaperId])
GO
ALTER TABLE [dbo].[Offset] CHECK CONSTRAINT [FK_Offset_Paper]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Orders_State] FOREIGN KEY([FkOrderState])
REFERENCES [dbo].[State] ([StateId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Orders_State]
GO
ALTER TABLE [dbo].[Print]  WITH CHECK ADD  CONSTRAINT [FK_Print_ClickCost] FOREIGN KEY([FkPrintClickCost])
REFERENCES [dbo].[ClickCost] ([ClickCostId])
GO
ALTER TABLE [dbo].[Print] CHECK CONSTRAINT [FK_Print_ClickCost]
GO
ALTER TABLE [dbo].[Print]  WITH CHECK ADD  CONSTRAINT [Order_Print_FK1] FOREIGN KEY([FkPrintOrder])
REFERENCES [dbo].[Order] ([OrderId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Print] CHECK CONSTRAINT [Order_Print_FK1]
GO
ALTER TABLE [dbo].[Print]  WITH CHECK ADD  CONSTRAINT [Paper_Print_FK1] FOREIGN KEY([FkPrintPaper])
REFERENCES [dbo].[Paper] ([PaperId])
GO
ALTER TABLE [dbo].[Print] CHECK CONSTRAINT [Paper_Print_FK1]
GO
