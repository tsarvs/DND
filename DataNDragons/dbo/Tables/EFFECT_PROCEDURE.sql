CREATE TABLE [dbo].[EFFECT_PROCEDURE] (
    [efp_id]        INT           NOT NULL,
    [efp_efid]      INT           NOT NULL,
    [efp_procedure] VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([efp_id] ASC),
    CONSTRAINT [FK_EFFECT_PROCEDURE_ToEFFECT] FOREIGN KEY ([efp_efid]) REFERENCES [dbo].[EFFECT] ([ef_id])
);

