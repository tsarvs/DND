CREATE TABLE [dbo].[SPELLS_EFFECT] (
    [sef_sid]  INT NOT NULL,
    [sef_efid] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([sef_efid] ASC, [sef_sid] ASC),
    CONSTRAINT [FK_SPELLS_EFFECT_ToEFFECT] FOREIGN KEY ([sef_efid]) REFERENCES [dbo].[EFFECT] ([ef_id]),
    CONSTRAINT [FK_SPELLS_EFFECT_ToSPELLS] FOREIGN KEY ([sef_sid]) REFERENCES [dbo].[SPELLS] ([s_id])
);

