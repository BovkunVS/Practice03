
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/17/2024 16:01:31
-- Generated from EDMX file: C:\Users\PC\source\repos\Practice03\Demo01_ModelFirst\ModelExibition.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TestDBExibition];
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

-- Creating table 'OwnerSet'
CREATE TABLE [dbo].[OwnerSet] (
    [id_owner] int IDENTITY(1,1) NOT NULL,
    [last_name] varchar(50)  NOT NULL,
    [first_name] varchar(50)  NOT NULL,
    [middle_name] varchar(50)  NOT NULL,
    [id_home_address] int  NOT NULL,
    [telephone] varchar(20)  NOT NULL
);
GO

-- Creating table 'CompanySet'
CREATE TABLE [dbo].[CompanySet] (
    [id_company] char(10)  NOT NULL,
    [name] varchar(50)  NOT NULL,
    [id_physical_address] int  NOT NULL,
    [id_owner] int  NOT NULL
);
GO

-- Creating table 'ProductsSet'
CREATE TABLE [dbo].[ProductsSet] (
    [id_products] char(10)  NOT NULL,
    [id_company] char(10)  NOT NULL,
    [product_type] varchar(20)  NOT NULL,
    [quantity] int  NOT NULL,
    [unit_price] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'ContractSet'
CREATE TABLE [dbo].[ContractSet] (
    [id_contract] int IDENTITY(10000,1) NOT NULL,
    [id_company_recipient] char(10)  NOT NULL,
    [id_company_supplier] char(10)  NOT NULL,
    [id_product] char(10)  NOT NULL,
    [date_of_conclusion] datetime  NOT NULL,
    [deadline] int  NOT NULL
);
GO

-- Creating table 'AddressSet'
CREATE TABLE [dbo].[AddressSet] (
    [id_address] int IDENTITY(1000,1) NOT NULL,
    [city] varchar(50)  NOT NULL,
    [street] varchar(50)  NOT NULL,
    [house] int  NOT NULL,
    [apartment] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id_owner] in table 'OwnerSet'
ALTER TABLE [dbo].[OwnerSet]
ADD CONSTRAINT [PK_OwnerSet]
    PRIMARY KEY CLUSTERED ([id_owner] ASC);
GO

-- Creating primary key on [id_company] in table 'CompanySet'
ALTER TABLE [dbo].[CompanySet]
ADD CONSTRAINT [PK_CompanySet]
    PRIMARY KEY CLUSTERED ([id_company] ASC);
GO

-- Creating primary key on [id_products] in table 'ProductsSet'
ALTER TABLE [dbo].[ProductsSet]
ADD CONSTRAINT [PK_ProductsSet]
    PRIMARY KEY CLUSTERED ([id_products] ASC);
GO

-- Creating primary key on [id_contract] in table 'ContractSet'
ALTER TABLE [dbo].[ContractSet]
ADD CONSTRAINT [PK_ContractSet]
    PRIMARY KEY CLUSTERED ([id_contract] ASC);
GO

-- Creating primary key on [id_address] in table 'AddressSet'
ALTER TABLE [dbo].[AddressSet]
ADD CONSTRAINT [PK_AddressSet]
    PRIMARY KEY CLUSTERED ([id_address] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [id_home_address] in table 'OwnerSet'
ALTER TABLE [dbo].[OwnerSet]
ADD CONSTRAINT [FK_AddressOwner]
    FOREIGN KEY ([id_home_address])
    REFERENCES [dbo].[AddressSet]
        ([id_address])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AddressOwner'
CREATE INDEX [IX_FK_AddressOwner]
ON [dbo].[OwnerSet]
    ([id_home_address]);
GO

-- Creating foreign key on [id_physical_address] in table 'CompanySet'
ALTER TABLE [dbo].[CompanySet]
ADD CONSTRAINT [FK_AddressCompany]
    FOREIGN KEY ([id_physical_address])
    REFERENCES [dbo].[AddressSet]
        ([id_address])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AddressCompany'
CREATE INDEX [IX_FK_AddressCompany]
ON [dbo].[CompanySet]
    ([id_physical_address]);
GO

-- Creating foreign key on [id_company] in table 'ProductsSet'
ALTER TABLE [dbo].[ProductsSet]
ADD CONSTRAINT [FK_CompanyProducts]
    FOREIGN KEY ([id_company])
    REFERENCES [dbo].[CompanySet]
        ([id_company])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyProducts'
CREATE INDEX [IX_FK_CompanyProducts]
ON [dbo].[ProductsSet]
    ([id_company]);
GO

-- Creating foreign key on [id_company_supplier] in table 'ContractSet'
ALTER TABLE [dbo].[ContractSet]
ADD CONSTRAINT [FK_CompanyContract]
    FOREIGN KEY ([id_company_supplier])
    REFERENCES [dbo].[CompanySet]
        ([id_company])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyContract'
CREATE INDEX [IX_FK_CompanyContract]
ON [dbo].[ContractSet]
    ([id_company_supplier]);
GO

-- Creating foreign key on [id_product] in table 'ContractSet'
ALTER TABLE [dbo].[ContractSet]
ADD CONSTRAINT [FK_ProductsContract]
    FOREIGN KEY ([id_product])
    REFERENCES [dbo].[ProductsSet]
        ([id_products])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductsContract'
CREATE INDEX [IX_FK_ProductsContract]
ON [dbo].[ContractSet]
    ([id_product]);
GO

-- Creating foreign key on [id_owner] in table 'CompanySet'
ALTER TABLE [dbo].[CompanySet]
ADD CONSTRAINT [FK_OwnerCompany]
    FOREIGN KEY ([id_owner])
    REFERENCES [dbo].[OwnerSet]
        ([id_owner])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OwnerCompany'
CREATE INDEX [IX_FK_OwnerCompany]
ON [dbo].[CompanySet]
    ([id_owner]);
GO

-- Creating foreign key on [id_company_recipient] in table 'ContractSet'
ALTER TABLE [dbo].[ContractSet]
ADD CONSTRAINT [FK_CompanyContract1]
    FOREIGN KEY ([id_company_recipient])
    REFERENCES [dbo].[CompanySet]
        ([id_company])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyContract1'
CREATE INDEX [IX_FK_CompanyContract1]
ON [dbo].[ContractSet]
    ([id_company_recipient]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------