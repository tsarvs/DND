﻿CREATE TABLE [dbo].[CHARACTER_BACKGROUND] (
    [cb_cid] INT NOT NULL,
    [cb_id] INT IDENTITY(1,1) NOT NULL,
    [cb_title] VARCHAR(100) NULL, 
    [cb_description] VARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([cb_id] ASC, [cb_cid] ASC),
    CONSTRAINT [FK_CHARACTER_BACKGROUND_ToCHARACTER] FOREIGN KEY ([cb_cid]) REFERENCES [dbo].[CHARACTER] ([c_id])
);

