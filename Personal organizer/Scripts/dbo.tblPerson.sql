CREATE TABLE [dbo].[tblPerson] 
(
    [Id]             INT        IDENTITY (1, 1) NOT NULL,
    [POUserID]       INT        NOT NULL,
    [NameFirst]      NCHAR (10) NULL,
    [NameLast]       NCHAR (10) NULL,
    [DateOfBirth]    DATETIME   NULL,
    [PhoneHome]      NCHAR (10) NULL,
    [PhoneMobile]    NCHAR (10) NULL,
    [GiftCategories] INT        NULL,
    [Email]          TEXT       NULL,
    [Notes]          TEXT       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'First name', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'tblPerson', @level2type = N'COLUMN', @level2name = N'NameFirst';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Last name', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'tblPerson', @level2type = N'COLUMN', @level2name = N'NameLast';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Birthday', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'tblPerson', @level2type = N'COLUMN', @level2name = N'DateOfBirth';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Phone (home)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'tblPerson', @level2type = N'COLUMN', @level2name = N'PhoneHome';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Phone (mobile)', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'tblPerson', @level2type = N'COLUMN', @level2name = N'PhoneMobile';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Types of gifts', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'tblPerson', @level2type = N'COLUMN', @level2name = N'GiftCategories';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Email address', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'tblPerson', @level2type = N'COLUMN', @level2name = N'Email';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Notes and comments', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'tblPerson', @level2type = N'COLUMN', @level2name = N'Notes';


GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'User',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblPerson',
    @level2type = N'COLUMN',
    @level2name = N'POUserID'