CREATE TABLE [dbo].[DiaryEntry] (
    [Id]          BIGINT          IDENTITY (1, 1) NOT NULL,
    [DiaryId]     BIGINT          NOT NULL,
    [EntryDate]   DATETIME2 (7)   NOT NULL,
    [Title]       NVARCHAR (50)   NOT NULL,
    [Text]        NVARCHAR (2000) NOT NULL,
    [DateChanged] DATETIME2 (7)   NOT NULL,
    CONSTRAINT [PK_DiaryEntry] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DiaryEntry_Diary] FOREIGN KEY ([DiaryId]) REFERENCES [dbo].[Diary] ([Id])
);

