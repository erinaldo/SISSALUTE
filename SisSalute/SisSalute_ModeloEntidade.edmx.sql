
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/26/2016 14:31:39
-- Generated from EDMX file: C:\Users\marcelo.victor\documents\visual studio 2013\Projects\SisSalute\SisSalute\SisSalute_ModeloEntidade.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SisSalute];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClientesEnderecos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clientes] DROP CONSTRAINT [FK_ClientesEnderecos];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfissionaisEnderecos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Profissionais] DROP CONSTRAINT [FK_ProfissionaisEnderecos];
GO
IF OBJECT_ID(N'[dbo].[FK_InsumoTratamentos_Insumo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InsumoTratamentos] DROP CONSTRAINT [FK_InsumoTratamentos_Insumo];
GO
IF OBJECT_ID(N'[dbo].[FK_InsumoTratamentos_Tratamentos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InsumoTratamentos] DROP CONSTRAINT [FK_InsumoTratamentos_Tratamentos];
GO
IF OBJECT_ID(N'[dbo].[FK_TratamentosConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaSet] DROP CONSTRAINT [FK_TratamentosConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientesConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultaSet] DROP CONSTRAINT [FK_ClientesConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfissionaisConsulta_Profissionais]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfissionaisConsulta] DROP CONSTRAINT [FK_ProfissionaisConsulta_Profissionais];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfissionaisConsulta_Consulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfissionaisConsulta] DROP CONSTRAINT [FK_ProfissionaisConsulta_Consulta];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Profissionais]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Profissionais];
GO
IF OBJECT_ID(N'[dbo].[Tratamentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tratamentos];
GO
IF OBJECT_ID(N'[dbo].[Enderecos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Enderecos];
GO
IF OBJECT_ID(N'[dbo].[Insumo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Insumo];
GO
IF OBJECT_ID(N'[dbo].[ConsultaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConsultaSet];
GO
IF OBJECT_ID(N'[dbo].[InsumoTratamentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InsumoTratamentos];
GO
IF OBJECT_ID(N'[dbo].[ProfissionaisConsulta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfissionaisConsulta];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [codCliente] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [cpf] nchar(11)  NULL,
    [numEndereco] nvarchar(max)  NULL,
    [telefone] nvarchar(11)  NULL,
    [celular2] nvarchar(11)  NULL,
    [celular1] nvarchar(11)  NULL,
    [email] nvarchar(max)  NULL,
    [facebook] nvarchar(max)  NULL,
    [profissao] nvarchar(max)  NULL,
    [estadoCivil] nvarchar(max)  NOT NULL,
    [dataNascimento] datetime  NOT NULL,
    [sexo] nvarchar(max)  NOT NULL,
    [dataCadastro] datetime  NOT NULL,
    [compEndereco] nvarchar(max)  NULL,
    [Enderecos_codEndereco] int  NOT NULL
);
GO

-- Creating table 'Profissionais'
CREATE TABLE [dbo].[Profissionais] (
    [codProfissional] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [especialidade] nvarchar(max)  NOT NULL,
    [celular] nvarchar(max)  NOT NULL,
    [telefone] nvarchar(max)  NULL,
    [email] nvarchar(max)  NULL,
    [numEndereco] nvarchar(max)  NULL,
    [compEndereco] nvarchar(max)  NULL,
    [Enderecos_codEndereco] int  NOT NULL
);
GO

-- Creating table 'Tratamentos'
CREATE TABLE [dbo].[Tratamentos] (
    [codTratamento] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [valor] float  NULL,
    [descricao] nvarchar(max)  NULL
);
GO

-- Creating table 'Enderecos'
CREATE TABLE [dbo].[Enderecos] (
    [codEndereco] int IDENTITY(1,1) NOT NULL,
    [endereco] nvarchar(max)  NULL,
    [bairro] nvarchar(max)  NULL,
    [cidade] nvarchar(max)  NULL,
    [estado] nvarchar(max)  NULL,
    [cep] nvarchar(max)  NULL,
    [logradouro] nvarchar(max)  NULL
);
GO

-- Creating table 'Insumo'
CREATE TABLE [dbo].[Insumo] (
    [codInsumo] int IDENTITY(1,1) NOT NULL,
    [nome] nvarchar(max)  NOT NULL,
    [custo] float  NULL,
    [descricao] nvarchar(max)  NULL,
    [tipo] nvarchar(max)  NULL,
    [origem] nvarchar(max)  NULL
);
GO

-- Creating table 'Consulta'
CREATE TABLE [dbo].[Consulta] (
    [codConsulta] int IDENTITY(1,1) NOT NULL,
    [valor] float  NOT NULL,
    [agenda] datetime  NOT NULL,
    [status] nvarchar(max)  NOT NULL,
    [sala] nvarchar(max)  NULL,
    [formaPagamento] nvarchar(max)  NOT NULL,
    [parcelamento] nvarchar(max)  NULL,
    [comissao] bit  NOT NULL,
    [Tratamentos_codTratamento] int  NOT NULL,
    [Clientes_codCliente] int  NOT NULL
);
GO

-- Creating table 'InsumoTratamentos'
CREATE TABLE [dbo].[InsumoTratamentos] (
    [Insumo_codInsumo] int  NOT NULL,
    [Tratamentos_codTratamento] int  NOT NULL
);
GO

-- Creating table 'ProfissionaisConsulta'
CREATE TABLE [dbo].[ProfissionaisConsulta] (
    [Profissionais_codProfissional] int  NOT NULL,
    [Consulta_codConsulta] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [codCliente] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([codCliente] ASC);
GO

-- Creating primary key on [codProfissional] in table 'Profissionais'
ALTER TABLE [dbo].[Profissionais]
ADD CONSTRAINT [PK_Profissionais]
    PRIMARY KEY CLUSTERED ([codProfissional] ASC);
GO

-- Creating primary key on [codTratamento] in table 'Tratamentos'
ALTER TABLE [dbo].[Tratamentos]
ADD CONSTRAINT [PK_Tratamentos]
    PRIMARY KEY CLUSTERED ([codTratamento] ASC);
GO

-- Creating primary key on [codEndereco] in table 'Enderecos'
ALTER TABLE [dbo].[Enderecos]
ADD CONSTRAINT [PK_Enderecos]
    PRIMARY KEY CLUSTERED ([codEndereco] ASC);
GO

-- Creating primary key on [codInsumo] in table 'Insumo'
ALTER TABLE [dbo].[Insumo]
ADD CONSTRAINT [PK_Insumo]
    PRIMARY KEY CLUSTERED ([codInsumo] ASC);
GO

-- Creating primary key on [codConsulta] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [PK_Consulta]
    PRIMARY KEY CLUSTERED ([codConsulta] ASC);
GO

-- Creating primary key on [Insumo_codInsumo], [Tratamentos_codTratamento] in table 'InsumoTratamentos'
ALTER TABLE [dbo].[InsumoTratamentos]
ADD CONSTRAINT [PK_InsumoTratamentos]
    PRIMARY KEY CLUSTERED ([Insumo_codInsumo], [Tratamentos_codTratamento] ASC);
GO

-- Creating primary key on [Profissionais_codProfissional], [Consulta_codConsulta] in table 'ProfissionaisConsulta'
ALTER TABLE [dbo].[ProfissionaisConsulta]
ADD CONSTRAINT [PK_ProfissionaisConsulta]
    PRIMARY KEY CLUSTERED ([Profissionais_codProfissional], [Consulta_codConsulta] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Enderecos_codEndereco] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [FK_ClientesEnderecos]
    FOREIGN KEY ([Enderecos_codEndereco])
    REFERENCES [dbo].[Enderecos]
        ([codEndereco])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientesEnderecos'
CREATE INDEX [IX_FK_ClientesEnderecos]
ON [dbo].[Clientes]
    ([Enderecos_codEndereco]);
GO

-- Creating foreign key on [Enderecos_codEndereco] in table 'Profissionais'
ALTER TABLE [dbo].[Profissionais]
ADD CONSTRAINT [FK_ProfissionaisEnderecos]
    FOREIGN KEY ([Enderecos_codEndereco])
    REFERENCES [dbo].[Enderecos]
        ([codEndereco])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfissionaisEnderecos'
CREATE INDEX [IX_FK_ProfissionaisEnderecos]
ON [dbo].[Profissionais]
    ([Enderecos_codEndereco]);
GO

-- Creating foreign key on [Insumo_codInsumo] in table 'InsumoTratamentos'
ALTER TABLE [dbo].[InsumoTratamentos]
ADD CONSTRAINT [FK_InsumoTratamentos_Insumo]
    FOREIGN KEY ([Insumo_codInsumo])
    REFERENCES [dbo].[Insumo]
        ([codInsumo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Tratamentos_codTratamento] in table 'InsumoTratamentos'
ALTER TABLE [dbo].[InsumoTratamentos]
ADD CONSTRAINT [FK_InsumoTratamentos_Tratamentos]
    FOREIGN KEY ([Tratamentos_codTratamento])
    REFERENCES [dbo].[Tratamentos]
        ([codTratamento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InsumoTratamentos_Tratamentos'
CREATE INDEX [IX_FK_InsumoTratamentos_Tratamentos]
ON [dbo].[InsumoTratamentos]
    ([Tratamentos_codTratamento]);
GO

-- Creating foreign key on [Tratamentos_codTratamento] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_TratamentosConsulta]
    FOREIGN KEY ([Tratamentos_codTratamento])
    REFERENCES [dbo].[Tratamentos]
        ([codTratamento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TratamentosConsulta'
CREATE INDEX [IX_FK_TratamentosConsulta]
ON [dbo].[Consulta]
    ([Tratamentos_codTratamento]);
GO

-- Creating foreign key on [Clientes_codCliente] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_ClientesConsulta]
    FOREIGN KEY ([Clientes_codCliente])
    REFERENCES [dbo].[Clientes]
        ([codCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientesConsulta'
CREATE INDEX [IX_FK_ClientesConsulta]
ON [dbo].[Consulta]
    ([Clientes_codCliente]);
GO

-- Creating foreign key on [Profissionais_codProfissional] in table 'ProfissionaisConsulta'
ALTER TABLE [dbo].[ProfissionaisConsulta]
ADD CONSTRAINT [FK_ProfissionaisConsulta_Profissionais]
    FOREIGN KEY ([Profissionais_codProfissional])
    REFERENCES [dbo].[Profissionais]
        ([codProfissional])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Consulta_codConsulta] in table 'ProfissionaisConsulta'
ALTER TABLE [dbo].[ProfissionaisConsulta]
ADD CONSTRAINT [FK_ProfissionaisConsulta_Consulta]
    FOREIGN KEY ([Consulta_codConsulta])
    REFERENCES [dbo].[Consulta]
        ([codConsulta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfissionaisConsulta_Consulta'
CREATE INDEX [IX_FK_ProfissionaisConsulta_Consulta]
ON [dbo].[ProfissionaisConsulta]
    ([Consulta_codConsulta]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------