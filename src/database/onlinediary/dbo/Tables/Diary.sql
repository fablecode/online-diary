CREATE TABLE [dbo].[Diary] (
    [Id]        BIGINT         IDENTITY (1, 1) NOT NULL,
    [Username]  NVARCHAR (256) NOT NULL,
    [FirstName] NVARCHAR (50)  NULL,
    [LastName]  NVARCHAR (50)  NULL,
    CONSTRAINT [PK_Diary] PRIMARY KEY CLUSTERED ([Id] ASC)
);

