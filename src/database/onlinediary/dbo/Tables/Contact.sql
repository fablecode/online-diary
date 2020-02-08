CREATE TABLE [dbo].[Contact] (
    [Id]           BIGINT         IDENTITY (1, 1) NOT NULL,
    [DiaryId]      BIGINT         NOT NULL,
    [FirstName]    NVARCHAR (50)  NULL,
    [LastName]     NVARCHAR (50)  NULL,
    [Telephone]    VARCHAR (50)   NULL,
    [MobilePhone]  VARBINARY (50) NULL,
    [Email]        NVARCHAR (250) NULL,
    [AddressLine1] NVARCHAR (250) NULL,
    [City]         NVARCHAR (100) NULL,
    [State]        NVARCHAR (100) NULL,
    [PostalCode]   NVARCHAR (50)  NULL,
    CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Contact_Diary] FOREIGN KEY ([DiaryId]) REFERENCES [dbo].[Diary] ([Id])
);

