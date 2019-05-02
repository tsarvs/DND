﻿CREATE TABLE [dbo].[RACE_SKILL] (
    [rs_rid] INT NOT NULL,
    [rs_sid] INT NOT NULL,
    CONSTRAINT [PK_RACE_SKILL] PRIMARY KEY CLUSTERED ([rs_rid] ASC, [rs_sid] ASC),
    CONSTRAINT [FK_RACE_SKILL_ToRACE] FOREIGN KEY ([rs_rid]) REFERENCES [dbo].[RACE] ([r_id]),
    CONSTRAINT [FK_RACE_SKILL_ToSKILL] FOREIGN KEY ([rs_sid]) REFERENCES [dbo].[SKILL] ([s_id])
);
