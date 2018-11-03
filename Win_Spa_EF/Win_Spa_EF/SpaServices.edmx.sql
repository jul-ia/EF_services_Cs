
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/03/2018 23:57:04
-- Generated from EDMX file: D:\IT Shag\Prog\С#\Forms\!current\EF_Spa\Win_Spa_EF\Win_Spa_EF\SpaServices.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SpaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CategorySet'
CREATE TABLE [dbo].[CategorySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ServicesSet'
CREATE TABLE [dbo].[ServicesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] float  NOT NULL,
    [Duration] int  NOT NULL,
    [IdCat] int  NOT NULL
);
GO

-- Creating table 'PurchaseSet'
CREATE TABLE [dbo].[PurchaseSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PersonName] nvarchar(max)  NOT NULL,
    [PhoneNum] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [IdService] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CategorySet'
ALTER TABLE [dbo].[CategorySet]
ADD CONSTRAINT [PK_CategorySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ServicesSet'
ALTER TABLE [dbo].[ServicesSet]
ADD CONSTRAINT [PK_ServicesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PurchaseSet'
ALTER TABLE [dbo].[PurchaseSet]
ADD CONSTRAINT [PK_PurchaseSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdCat] in table 'ServicesSet'
ALTER TABLE [dbo].[ServicesSet]
ADD CONSTRAINT [FK_CategoryServices]
    FOREIGN KEY ([IdCat])
    REFERENCES [dbo].[CategorySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryServices'
CREATE INDEX [IX_FK_CategoryServices]
ON [dbo].[ServicesSet]
    ([IdCat]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------