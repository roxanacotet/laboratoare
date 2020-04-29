
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/21/2020 17:13:02
-- Generated from EDMX file: D:\facultate\.net\project\MyPhotosManager\MyPhotosManager\MyPhotosManagerDataAccess\MyPhotosManagerModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotosManagerDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PhotosDetails_Details]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotosDetails] DROP CONSTRAINT [FK_PhotosDetails_Details];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotosDetails_Photos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotosDetails] DROP CONSTRAINT [FK_PhotosDetails_Photos];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotosEvents]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Photos] DROP CONSTRAINT [FK_PhotosEvents];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotosPeoples_Peoples]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotosPeoples] DROP CONSTRAINT [FK_PhotosPeoples_Peoples];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotosPeoples_Photos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotosPeoples] DROP CONSTRAINT [FK_PhotosPeoples_Photos];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Details]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Details];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[Peoples]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Peoples];
GO
IF OBJECT_ID(N'[dbo].[Photos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Photos];
GO
IF OBJECT_ID(N'[dbo].[PhotosDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhotosDetails];
GO
IF OBJECT_ID(N'[dbo].[PhotosPeoples]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhotosPeoples];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [CreationDate] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [IsDeleted] bit  NOT NULL,
    [IsVideo] bit  NOT NULL,
    [Event_Id] int  NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdPhoto] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Peoples'
CREATE TABLE [dbo].[Peoples] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdPhoto] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Details'
CREATE TABLE [dbo].[Details] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdPhoto] int  NOT NULL,
    [DetailKey] nvarchar(max)  NOT NULL,
    [DetailValue] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PhotosPeoples'
CREATE TABLE [dbo].[PhotosPeoples] (
    [Photos_Id] int  NOT NULL,
    [Peoples_Id] int  NOT NULL
);
GO

-- Creating table 'PhotosDetails'
CREATE TABLE [dbo].[PhotosDetails] (
    [Photos_Id] int  NOT NULL,
    [Details_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Peoples'
ALTER TABLE [dbo].[Peoples]
ADD CONSTRAINT [PK_Peoples]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Details'
ALTER TABLE [dbo].[Details]
ADD CONSTRAINT [PK_Details]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Photos_Id], [Peoples_Id] in table 'PhotosPeoples'
ALTER TABLE [dbo].[PhotosPeoples]
ADD CONSTRAINT [PK_PhotosPeoples]
    PRIMARY KEY CLUSTERED ([Photos_Id], [Peoples_Id] ASC);
GO

-- Creating primary key on [Photos_Id], [Details_Id] in table 'PhotosDetails'
ALTER TABLE [dbo].[PhotosDetails]
ADD CONSTRAINT [PK_PhotosDetails]
    PRIMARY KEY CLUSTERED ([Photos_Id], [Details_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Event_Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [FK_PhotosEvents]
    FOREIGN KEY ([Event_Id])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotosEvents'
CREATE INDEX [IX_FK_PhotosEvents]
ON [dbo].[Photos]
    ([Event_Id]);
GO

-- Creating foreign key on [Photos_Id] in table 'PhotosPeoples'
ALTER TABLE [dbo].[PhotosPeoples]
ADD CONSTRAINT [FK_PhotosPeoples_Photos]
    FOREIGN KEY ([Photos_Id])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Peoples_Id] in table 'PhotosPeoples'
ALTER TABLE [dbo].[PhotosPeoples]
ADD CONSTRAINT [FK_PhotosPeoples_Peoples]
    FOREIGN KEY ([Peoples_Id])
    REFERENCES [dbo].[Peoples]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotosPeoples_Peoples'
CREATE INDEX [IX_FK_PhotosPeoples_Peoples]
ON [dbo].[PhotosPeoples]
    ([Peoples_Id]);
GO

-- Creating foreign key on [Photos_Id] in table 'PhotosDetails'
ALTER TABLE [dbo].[PhotosDetails]
ADD CONSTRAINT [FK_PhotosDetails_Photos]
    FOREIGN KEY ([Photos_Id])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Details_Id] in table 'PhotosDetails'
ALTER TABLE [dbo].[PhotosDetails]
ADD CONSTRAINT [FK_PhotosDetails_Details]
    FOREIGN KEY ([Details_Id])
    REFERENCES [dbo].[Details]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotosDetails_Details'
CREATE INDEX [IX_FK_PhotosDetails_Details]
ON [dbo].[PhotosDetails]
    ([Details_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------