﻿CREATE TABLE [dbo].[CHARACTER_JOURNAL]
(
	[cj_cid] INT NOT NULL , 
    [cj_entryID] INT IDENTITY(1,1) NOT NULL, 
    [cj_text] VARCHAR(MAX) NULL, 
    PRIMARY KEY ([cj_entryID], [cj_cid]), 
    CONSTRAINT [FK_CHARACTER_JOURNAL_ToCHARACTER] FOREIGN KEY ([cj_cid]) REFERENCES [CHARACTER]([c_id])
)