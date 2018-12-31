CREATE TABLE [dbo].[tblPO-User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SysName] NCHAR(255) NOT NULL, 
    [DisplayName] NCHAR(20) NOT NULL, 
    [Password] NCHAR(10) NULL, 
    [DateCreated] DATETIME NULL, 
    [LastLogin] DATETIME NULL, 
    [FailedLogins] INT NULL
)
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'System name',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblPO-User',
    @level2type = N'COLUMN',
    @level2name = N'SysName'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Display name',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblPO-User',
    @level2type = N'COLUMN',
    @level2name = N'DisplayName'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Password',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblPO-User',
    @level2type = N'COLUMN',
    @level2name = N'Password'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Date user created',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblPO-User',
    @level2type = N'COLUMN',
    @level2name = N'DateCreated'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Last login',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblPO-User',
    @level2type = N'COLUMN',
    @level2name = N'LastLogin'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Failed logins',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblPO-User',
    @level2type = N'COLUMN',
    @level2name = 'FailedLogins'