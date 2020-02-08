CREATE TABLE [dbo].[DiaryEvent] (
    [Id]            BIGINT         IDENTITY (1, 1) NOT NULL,
    [DiaryId]       BIGINT         NOT NULL,
    [Name]          NVARCHAR (50)  NOT NULL,
    [Description]   NVARCHAR (250) NULL,
    [EventDate]     DATETIME2 (7)  NOT NULL,
    [EventDuration] INT            NOT NULL,
    CONSTRAINT [PK_DiaryEvent] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DiaryEvent_Diary] FOREIGN KEY ([DiaryId]) REFERENCES [dbo].[Diary] ([Id])
);

