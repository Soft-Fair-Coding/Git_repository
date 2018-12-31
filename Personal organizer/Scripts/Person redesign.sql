USE [PO-Data]
GO

EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'CONSTRAINT',@level2name=N'FK_POUserID_tblPOUser_ID'

GO

EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'Notes'

GO

EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'Email'

GO

EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'GiftCategories'

GO

EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'PhoneMobile'

GO

EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'PhoneHome'

GO

EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'DateOfBirth'

GO

EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'NameLast'

GO

EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'NameFirst'

GO

EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'POUserID'

GO

ALTER TABLE [dbo].[tblPerson] DROP CONSTRAINT [FK_POUserID_tblPOUser_ID]
GO

/****** Object:  Table [dbo].[tblPerson]    Script Date: 16/12/2018 21:03:48 ******/
DROP TABLE [dbo].[tblPerson]
GO

/****** Object:  Table [dbo].[tblPerson]    Script Date: 16/12/2018 21:03:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPerson](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[POUserID] [int] NOT NULL,
	[NameFirst] [nchar](10) NULL,
	[NameLast] [nchar](10) NULL,
	[DateOfBirth] [datetime] NULL,
	[PhoneHome] [nchar](10) NULL,
	[PhoneMobile] [nchar](10) NULL,
	[Address] [nchar](200) NULL,
	[Email] [text] NULL,
	[GiftCategories] [int] NULL,
	[Notes] [text] NULL,
 CONSTRAINT [PK__tblPerson] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[tblPerson]  WITH CHECK ADD  CONSTRAINT [FK_POUserID_tblPOUser_ID] FOREIGN KEY([POUserID])
REFERENCES [dbo].[tblPOUser] ([Id])
GO

ALTER TABLE [dbo].[tblPerson] CHECK CONSTRAINT [FK_POUserID_tblPOUser_ID]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'User' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'POUserID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'First name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'NameFirst'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'NameLast'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Birthday' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'DateOfBirth'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Phone (home)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'PhoneHome'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Phone (mobile)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'PhoneMobile'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Types of gifts' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'GiftCategories'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email address' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'Email'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Notes and comments' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'Notes'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Address' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'COLUMN',@level2name=N'Address'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'tblPOUser.ID is a foreign key for tblPerson.POUserID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblPerson', @level2type=N'CONSTRAINT',@level2name=N'FK_POUserID_tblPOUser_ID'
GO


