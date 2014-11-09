
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/02/2014 16:28:29
-- Generated from EDMX file: d:\Documents\Visual Studio 2013\Projects\Project8\ICCardSystem\Models\ICModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ICCardSystem];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BqxxbSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BqxxbSet];
GO
IF OBJECT_ID(N'[dbo].[bhIndexSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[bhIndexSet];
GO
IF OBJECT_ID(N'[dbo].[bqjzhSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[bqjzhSet];
GO
IF OBJECT_ID(N'[dbo].[czrySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[czrySet];
GO
IF OBJECT_ID(N'[dbo].[djglSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[djglSet];
GO
IF OBJECT_ID(N'[dbo].[hbjlSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[hbjlSet];
GO
IF OBJECT_ID(N'[dbo].[hmdSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[hmdSet];
GO
IF OBJECT_ID(N'[dbo].[hmdjsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[hmdjsSet];
GO
IF OBJECT_ID(N'[dbo].[jdlxSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[jdlxSet];
GO
IF OBJECT_ID(N'[dbo].[wxdjSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[wxdjSet];
GO
IF OBJECT_ID(N'[dbo].[ycxxbSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ycxxbSet];
GO
IF OBJECT_ID(N'[dbo].[yhxxSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[yhxxSet];
GO
IF OBJECT_ID(N'[dbo].[yyglSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[yyglSet];
GO
IF OBJECT_ID(N'[dbo].[yysjSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[yysjSet];
GO
IF OBJECT_ID(N'[dbo].[zxglSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[zxglSet];
GO
IF OBJECT_ID(N'[dbo].[czjlbSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[czjlbSet];
GO
IF OBJECT_ID(N'[dbo].[Admins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Admins];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BqxxbSet'
CREATE TABLE [dbo].[BqxxbSet] (
    [fid] int IDENTITY(1,1) NOT NULL,
    [ywbh] int  NOT NULL,
    [gqzl] float  NOT NULL,
    [bzm] float  NOT NULL,
    [bcbqzl] float  NOT NULL,
    [ybql] float  NOT NULL,
    [bqwc] int  NOT NULL,
    [wxdbh] int  NULL
);
GO

-- Creating table 'bhIndexSet'
CREATE TABLE [dbo].[bhIndexSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ywbh] int  NOT NULL
);
GO

-- Creating table 'bqjzhSet'
CREATE TABLE [dbo].[bqjzhSet] (
    [djbh] int IDENTITY(1,1) NOT NULL,
    [ywbh] int  NOT NULL,
    [wxdbh] nvarchar(50)  NOT NULL,
    [bql] float  NOT NULL,
    [czy] nvarchar(50)  NOT NULL,
    [rq] datetime  NOT NULL,
    [hh] int  NOT NULL
);
GO

-- Creating table 'czrySet'
CREATE TABLE [dbo].[czrySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [bh] nvarchar(50)  NOT NULL,
    [xm] nvarchar(50)  NOT NULL,
    [dm] nvarchar(50)  NOT NULL,
    [opId] int  NULL,
    [zcyy] int  NOT NULL,
    [FAgencyCode] int  NULL
);
GO

-- Creating table 'djglSet'
CREATE TABLE [dbo].[djglSet] (
    [yhlx] int  NOT NULL,
    [qj] decimal(18,0)  NOT NULL,
    [ms] nvarchar(50)  NOT NULL,
    [ckxl] int  NOT NULL,
    [yxl] int  NOT NULL,
    [bx] int  NOT NULL,
    [gs] tinyint  NULL,
    [ID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'hbjlSet'
CREATE TABLE [dbo].[hbjlSet] (
    [ywbh] int  NOT NULL,
    [bzm] nvarchar(50)  NOT NULL,
    [rq] datetime  NOT NULL,
    [czy] nvarchar(50)  NOT NULL,
    [wxdbh] int  NULL,
    [dqqm] float  NULL,
    [dqbh] nvarchar(50)  NOT NULL,
    [cxbz] int  NULL,
    [ID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'hmdSet'
CREATE TABLE [dbo].[hmdSet] (
    [f_id] int IDENTITY(1,1) NOT NULL,
    [ywbh] int  NOT NULL,
    [bql] int  NOT NULL,
    [hb] int  NOT NULL,
    [sdyh] int  NOT NULL,
    [yy] int  NOT NULL,
    [rq] datetime  NOT NULL,
    [gqzl] int  NOT NULL,
    [sdczy] nvarchar(50)  NOT NULL,
    [bz] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'hmdjsSet'
CREATE TABLE [dbo].[hmdjsSet] (
    [ywbh] int  NOT NULL,
    [jsrq] datetime  NOT NULL,
    [czy] nvarchar(50)  NOT NULL,
    [jsyy] int  NOT NULL,
    [bz] nvarchar(50)  NOT NULL,
    [ID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'jdlxSet'
CREATE TABLE [dbo].[jdlxSet] (
    [jdlxId] int  NOT NULL,
    [ms] nvarchar(200)  NOT NULL,
    [ID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'wxdjSet'
CREATE TABLE [dbo].[wxdjSet] (
    [wxdbh] int IDENTITY(1,1) NOT NULL,
    [ywbh] int  NOT NULL,
    [yh] nvarchar(50)  NOT NULL,
    [zz] nvarchar(50)  NOT NULL,
    [tel] nvarchar(50)  NOT NULL,
    [xlsj] datetime  NOT NULL,
    [gzdm] int  NOT NULL,
    [hb] tinyint  NOT NULL,
    [bzm] float  NULL,
    [BefBh] nvarchar(100)  NOT NULL,
    [NowBh] nvarchar(100)  NOT NULL,
    [wxyy] int  NULL,
    [wxcs] int  NULL,
    [syql] float  NULL,
    [bz] nvarchar(100)  NULL,
    [czy] nvarchar(50)  NULL
);
GO

-- Creating table 'ycxxbSet'
CREATE TABLE [dbo].[ycxxbSet] (
    [ywbh] int  NULL,
    [hm] nvarchar(50)  NOT NULL,
    [zz] nvarchar(50)  NOT NULL,
    [tel] nvarchar(50)  NOT NULL,
    [gqzl] int  NULL,
    [zhgql] int  NULL,
    [gqrq] datetime  NULL,
    [sfyc] int  NULL,
    [rq] datetime  NULL,
    [ID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'yhxxSet'
CREATE TABLE [dbo].[yhxxSet] (
    [ywbh] int  NOT NULL,
    [hm] nvarchar(50)  NULL,
    [zz] nvarchar(50)  NOT NULL,
    [tel] nvarchar(50)  NULL,
    [bz] nvarchar(200)  NULL,
    [jdrq] datetime  NULL,
    [gqcs] int  NULL,
    [gqzl] float  NULL,
    [jdczy] nvarchar(50)  NULL,
    [gqrq] datetime  NULL,
    [xbzm] float  NULL,
    [yhmm] nvarchar(50)  NULL,
    [bqzl] float  NULL,
    [bqcs] int  NULL,
    [yhlx] int  NULL,
    [sdbj] int  NULL,
    [fkrq] datetime  NULL,
    [gqd] nvarchar(50)  NULL,
    [kpbh] int IDENTITY(1,1) NOT NULL,
    [zxh] nvarchar(50)  NULL,
    [jdlx] int  NULL,
    [yhkx] int  NULL,
    [qtlx] int  NULL
);
GO

-- Creating table 'yyglSet'
CREATE TABLE [dbo].[yyglSet] (
    [bh] int IDENTITY(1,1) NOT NULL,
    [ms] nvarchar(100)  NOT NULL,
    [lx] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'yysjSet'
CREATE TABLE [dbo].[yysjSet] (
    [fid] int IDENTITY(1,1) NOT NULL,
    [ywbh] int  NOT NULL,
    [skcs] int  NOT NULL,
    [skrq] datetime  NOT NULL,
    [skje] decimal(18,0)  NOT NULL,
    [skql] float  NOT NULL,
    [czy] nvarchar(50)  NOT NULL,
    [bb] int  NOT NULL,
    [hh] int  NOT NULL,
    [sjkb] int  NOT NULL,
    [time] datetime  NOT NULL,
    [gzzbh] int  NOT NULL,
    [lstbz] int  NOT NULL,
    [bqbz] int  NOT NULL,
    [zfbz] int  NOT NULL,
    [fpbh] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'zxglSet'
CREATE TABLE [dbo].[zxglSet] (
    [zxh] nvarchar(50)  NOT NULL,
    [zxmc] nvarchar(50)  NOT NULL,
    [dsdbh] int  NOT NULL,
    [ID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'czjlbSet'
CREATE TABLE [dbo].[czjlbSet] (
    [ywbh] int  NOT NULL,
    [skrq] datetime  NOT NULL,
    [skje] decimal(18,0)  NOT NULL,
    [skql] int  NOT NULL,
    [fpbh] nvarchar(50)  NOT NULL,
    [zfbz] int  NOT NULL,
    [jlyy] int  NOT NULL,
    [czy] nvarchar(50)  NOT NULL,
    [ID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Admins'
CREATE TABLE [dbo].[Admins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [WorkId] nvarchar(10)  NOT NULL,
    [Name] nvarchar(20)  NOT NULL,
    [Password] nvarchar(42)  NOT NULL,
    [AdminLevel] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [fid] in table 'BqxxbSet'
ALTER TABLE [dbo].[BqxxbSet]
ADD CONSTRAINT [PK_BqxxbSet]
    PRIMARY KEY CLUSTERED ([fid] ASC);
GO

-- Creating primary key on [Id] in table 'bhIndexSet'
ALTER TABLE [dbo].[bhIndexSet]
ADD CONSTRAINT [PK_bhIndexSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [djbh] in table 'bqjzhSet'
ALTER TABLE [dbo].[bqjzhSet]
ADD CONSTRAINT [PK_bqjzhSet]
    PRIMARY KEY CLUSTERED ([djbh] ASC);
GO

-- Creating primary key on [Id] in table 'czrySet'
ALTER TABLE [dbo].[czrySet]
ADD CONSTRAINT [PK_czrySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ID] in table 'djglSet'
ALTER TABLE [dbo].[djglSet]
ADD CONSTRAINT [PK_djglSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'hbjlSet'
ALTER TABLE [dbo].[hbjlSet]
ADD CONSTRAINT [PK_hbjlSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [f_id] in table 'hmdSet'
ALTER TABLE [dbo].[hmdSet]
ADD CONSTRAINT [PK_hmdSet]
    PRIMARY KEY CLUSTERED ([f_id] ASC);
GO

-- Creating primary key on [ID] in table 'hmdjsSet'
ALTER TABLE [dbo].[hmdjsSet]
ADD CONSTRAINT [PK_hmdjsSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'jdlxSet'
ALTER TABLE [dbo].[jdlxSet]
ADD CONSTRAINT [PK_jdlxSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [wxdbh] in table 'wxdjSet'
ALTER TABLE [dbo].[wxdjSet]
ADD CONSTRAINT [PK_wxdjSet]
    PRIMARY KEY CLUSTERED ([wxdbh] ASC);
GO

-- Creating primary key on [ID] in table 'ycxxbSet'
ALTER TABLE [dbo].[ycxxbSet]
ADD CONSTRAINT [PK_ycxxbSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [kpbh] in table 'yhxxSet'
ALTER TABLE [dbo].[yhxxSet]
ADD CONSTRAINT [PK_yhxxSet]
    PRIMARY KEY CLUSTERED ([kpbh] ASC);
GO

-- Creating primary key on [bh] in table 'yyglSet'
ALTER TABLE [dbo].[yyglSet]
ADD CONSTRAINT [PK_yyglSet]
    PRIMARY KEY CLUSTERED ([bh] ASC);
GO

-- Creating primary key on [fid] in table 'yysjSet'
ALTER TABLE [dbo].[yysjSet]
ADD CONSTRAINT [PK_yysjSet]
    PRIMARY KEY CLUSTERED ([fid] ASC);
GO

-- Creating primary key on [ID] in table 'zxglSet'
ALTER TABLE [dbo].[zxglSet]
ADD CONSTRAINT [PK_zxglSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'czjlbSet'
ALTER TABLE [dbo].[czjlbSet]
ADD CONSTRAINT [PK_czjlbSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Id] in table 'Admins'
ALTER TABLE [dbo].[Admins]
ADD CONSTRAINT [PK_Admins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------