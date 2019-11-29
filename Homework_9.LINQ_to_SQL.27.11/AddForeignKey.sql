USE [Cinema]
GO

/****** Object:  Table [dbo].[Movies]    Script Date: 29.11.2019 21:24:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Movies]
(
	[DirectorId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NOT NULL,
	[Genre] [nvarchar](20) NOT NULL,
	[Year] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Movies]  WITH CHECK ADD FOREIGN KEY([DirectorId])
REFERENCES [dbo].[Directors] ([Id])
GO

ALTER TABLE [dbo].[Movies]  WITH CHECK ADD FOREIGN KEY([DirectorId])
REFERENCES [dbo].[Directors] ([Id])
GO


