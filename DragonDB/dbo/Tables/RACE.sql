CREATE TABLE [dbo].[RACE] (
    [r_id]   INT IDENTITY(1,1) NOT NULL,
    [r_name] VARCHAR (100) NULL,
    [r_description] VARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([r_id] ASC)
);

