CREATE TABLE [dbo].[SKILL] (
    [s_id]             INT IDENTITY(1,1) NOT NULL,
    [s_animalhandling] INT DEFAULT ((0)) NULL,
    [s_arcana]         INT DEFAULT ((0)) NULL,
    [s_athletics]      INT DEFAULT ((0)) NULL,
    [s_deception]      INT DEFAULT ((0)) NULL,
    [s_history]        INT DEFAULT ((0)) NULL,
    [s_insight]        INT DEFAULT ((0)) NULL,
    [s_intimidation]   INT DEFAULT ((0)) NULL,
    [s_medicine]       INT DEFAULT ((0)) NULL,
    [s_nature]         INT DEFAULT ((0)) NULL,
    [s_perception]     INT DEFAULT ((0)) NULL,
    [s_performance]    INT DEFAULT ((0)) NULL,
    [s_persuasion]     INT DEFAULT ((0)) NULL,
    [s_religion]       INT DEFAULT ((0)) NULL,
    [s_sleightofhand]  INT DEFAULT ((0)) NULL,
    [s_stealth]        INT DEFAULT ((0)) NULL,
    [s_survival]       INT DEFAULT ((0)) NULL,
    CONSTRAINT [PK_SKILL] PRIMARY KEY CLUSTERED ([s_id] ASC)
);

