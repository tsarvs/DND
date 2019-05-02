CREATE TABLE [dbo].[EFFECT] (
    [ef_id]           INT           NOT NULL,
    [ef_name]         VARCHAR (150) NULL,
    [ef_desc]         VARCHAR (MAX) NULL,
    [ef_hasprocedure] BIT           NULL,
    PRIMARY KEY CLUSTERED ([ef_id] ASC)
);

