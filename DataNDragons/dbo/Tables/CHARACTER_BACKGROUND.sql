﻿CREATE TABLE [dbo].[CHARACTER_BACKGROUND] (
    [cb_cid] INT NOT NULL,
    [cb_bid] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([cb_bid] ASC, [cb_cid] ASC),
    CONSTRAINT [FK_CHARACTER_BACKGROUND_ToBACKGROUND] FOREIGN KEY ([cb_bid]) REFERENCES [dbo].[BACKGROUND] ([b_id]),
    CONSTRAINT [FK_CHARACTER_BACKGROUND_ToCHARACTER] FOREIGN KEY ([cb_cid]) REFERENCES [dbo].[CHARACTER] ([c_id])
);

