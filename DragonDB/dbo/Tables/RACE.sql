CREATE TABLE [dbo].[RACE] (
    [r_id]   INT IDENTITY(1,1) NOT NULL,
    [r_name] VARCHAR (100) NULL,
    [r_description] VARCHAR(MAX) NULL, 
    [r_aid] INT NULL, 
    PRIMARY KEY CLUSTERED ([r_id] ASC), 
    CONSTRAINT [FK_RACE_ToABILITY] FOREIGN KEY ([r_aid]) REFERENCES [ABILITY]([a_id])
);

