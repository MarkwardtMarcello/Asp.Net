CREATE TABLE [dbo].[Produto] (
    [Id]        INT            NOT NULL,
    [Nome]      NVARCHAR (50)  NOT NULL,
    [Descricao] NVARCHAR (MAX) NULL,
    [CategoriaID] INT NOT NULL DEFAULT 1, 
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Produto_Categoria] FOREIGN KEY ([CategoriaID]) REFERENCES [Categoria]([Id])
);

