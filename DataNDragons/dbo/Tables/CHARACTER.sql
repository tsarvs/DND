CREATE TABLE [dbo].[CHARACTER] (
    [c_id]                   INT IDENTITY(1,1) NOT NULL,
    [c_name]                 VARCHAR (100) NULL,
	[c_rid]					 INT		   NULL,
    [c_alignment]            VARCHAR (25)  NULL,
    [c_hpcurrent]            INT           NULL,
    [c_hpmax]                INT           NULL,
    [c_hptemp]               INT           NULL,
    [c_inspiration]          BIT           NULL,
    [c_spellslots_remaining] INT           NULL,
    [c_spellslots_total]     INT           NULL,
    [c_bid]                  INT           NULL,
    [c_isNPC]                BIT           DEFAULT 0 NULL,
    PRIMARY KEY CLUSTERED ([c_id] ASC),
    CONSTRAINT [FK_CHARACTER_ToSPELLS_SLOTS_remaining] FOREIGN KEY ([c_spellslots_remaining]) REFERENCES [dbo].[SPELLS_SLOTS] ([ss_id]),
    CONSTRAINT [FK_CHARACTER_ToSPELLS_SLOTS_total] FOREIGN KEY ([c_spellslots_total]) REFERENCES [dbo].[SPELLS_SLOTS] ([ss_id]),
	CONSTRAINT [FK_CHARACTER_ToRACE] FOREIGN KEY ([c_rid]) REFERENCES [dbo].[RACE] ([r_id])
);

