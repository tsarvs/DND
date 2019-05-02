CREATE TABLE [dbo].[SPELLS_SLOTS] (
    [ss_id]   INT NOT NULL,
    [ss_lvl1] INT DEFAULT ((0)) NULL,
    [ss_lvl2] INT DEFAULT ((0)) NULL,
    [ss_lvl3] INT DEFAULT ((0)) NULL,
    [ss_lvl4] INT DEFAULT ((0)) NULL,
    [ss_lvl5] INT DEFAULT ((0)) NULL,
    [ss_lvl6] INT DEFAULT ((0)) NULL,
    [ss_lvl7] INT DEFAULT ((0)) NULL,
    [ss_lvl8] INT DEFAULT ((0)) NULL,
    [ss_lvl9] INT DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([ss_id] ASC)
);

