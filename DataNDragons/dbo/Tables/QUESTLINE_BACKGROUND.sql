﻿CREATE TABLE [dbo].[QUESTLINE_BACKGROUND] (
    [qlb_qlid] INT NOT NULL,
    [qlb_bid]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([qlb_bid] ASC, [qlb_qlid] ASC),
    CONSTRAINT [FK_QUESTLINE_BACKGROUND_ToBACKGROUND] FOREIGN KEY ([qlb_bid]) REFERENCES [dbo].[BACKGROUND] ([b_id]),
    CONSTRAINT [FK_QUESTLINE_BACKGROUND_ToQUESTLINE] FOREIGN KEY ([qlb_qlid]) REFERENCES [dbo].[QUESTLINE] ([ql_id])
);

