
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/07/2022 18:38:27
-- Generated from EDMX file: C:\Users\PC\source\repos\Trabajo POO Grupo 4\Modelo\Contexto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Trabajo_POO_Grupo4];
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

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Grupos'
CREATE TABLE [dbo].[Grupos] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'UsuarioGrupo'
CREATE TABLE [dbo].[UsuarioGrupo] (
    [Usuario_Id] int  NOT NULL,
    [Grupo_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Grupos'
ALTER TABLE [dbo].[Grupos]
ADD CONSTRAINT [PK_Grupos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Usuario_Id], [Grupo_Id] in table 'UsuarioGrupo'
ALTER TABLE [dbo].[UsuarioGrupo]
ADD CONSTRAINT [PK_UsuarioGrupo]
    PRIMARY KEY CLUSTERED ([Usuario_Id], [Grupo_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Usuario_Id] in table 'UsuarioGrupo'
ALTER TABLE [dbo].[UsuarioGrupo]
ADD CONSTRAINT [FK_UsuarioGrupo_Usuario]
    FOREIGN KEY ([Usuario_Id])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Grupo_Id] in table 'UsuarioGrupo'
ALTER TABLE [dbo].[UsuarioGrupo]
ADD CONSTRAINT [FK_UsuarioGrupo_Grupo]
    FOREIGN KEY ([Grupo_Id])
    REFERENCES [dbo].[Grupos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioGrupo_Grupo'
CREATE INDEX [IX_FK_UsuarioGrupo_Grupo]
ON [dbo].[UsuarioGrupo]
    ([Grupo_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------