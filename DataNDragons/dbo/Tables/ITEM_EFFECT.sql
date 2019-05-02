CREATE TABLE [dbo].[ITEM_EFFECT] (
    [ie_iid]  INT NOT NULL,
    [if_efid] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([if_efid] ASC, [ie_iid] ASC),
    CONSTRAINT [FK_ITEM_EFFECT_ToEFFECT] FOREIGN KEY ([if_efid]) REFERENCES [dbo].[EFFECT] ([ef_id]),
    CONSTRAINT [FK_ITEM_EFFECT_ToITEM] FOREIGN KEY ([ie_iid]) REFERENCES [dbo].[ITEM] ([i_id])
);

