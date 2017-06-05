
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/05/2017 09:53:49
-- Generated from EDMX file: C:\Markwardt\ProjetosMarceloMarkwardt\CadastroFerramenta\CadastroFerramenta\Model\BancoFerramenta.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BancoFerramenta];
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

-- Creating table 'Ferramentas'
CREATE TABLE [dbo].[Ferramentas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Diametro] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Producao] nvarchar(max)  NOT NULL,
    [MaquinaId] int  NOT NULL
);
GO

-- Creating table 'Maquinas'
CREATE TABLE [dbo].[Maquinas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Produto] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Ferramentas'
ALTER TABLE [dbo].[Ferramentas]
ADD CONSTRAINT [PK_Ferramentas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Maquinas'
ALTER TABLE [dbo].[Maquinas]
ADD CONSTRAINT [PK_Maquinas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MaquinaId] in table 'Ferramentas'
ALTER TABLE [dbo].[Ferramentas]
ADD CONSTRAINT [FK_MaquinaFerramenta]
    FOREIGN KEY ([MaquinaId])
    REFERENCES [dbo].[Maquinas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MaquinaFerramenta'
CREATE INDEX [IX_FK_MaquinaFerramenta]
ON [dbo].[Ferramentas]
    ([MaquinaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------