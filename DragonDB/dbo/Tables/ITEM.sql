CREATE TABLE [dbo].[ITEM] (
    [i_id]     INT IDENTITY(1,1) NOT NULL,
    [i_weight] DECIMAL (18) NULL,
    [i_gp]     DECIMAL (18) NULL,
    [i_description] VARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([i_id] ASC)
);

