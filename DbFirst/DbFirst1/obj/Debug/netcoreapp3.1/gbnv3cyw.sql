IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Alumnos] (
    [IDAlumnos] int NOT NULL IDENTITY,
    [Dni] char(8) NOT NULL,
    [Apellidos] varchar(100) NOT NULL,
    [Nombres] varchar(100) NOT NULL,
    [Sexo] char(1) NOT NULL,
    [FechaNac] date NOT NULL,
    [Direccion] varchar(100) NOT NULL,
    CONSTRAINT [PK__Alumnos__776B659D9788C7C4] PRIMARY KEY ([IDAlumnos])
);

GO

CREATE TABLE [Customers] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NULL,
    [Surname] nvarchar(50) NULL
);

GO

CREATE TABLE [Productos] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] varchar(50) NOT NULL,
    [Descrip] varchar(100) NOT NULL,
    [Imagen] varchar(max) NULL,
    [Precio] decimal(14, 2) NULL,
    CONSTRAINT [PK_Productos] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200227180212_Initial', N'3.1.2');

GO

