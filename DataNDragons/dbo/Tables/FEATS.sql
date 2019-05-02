CREATE TABLE [dbo].[FEATS] (
    [f_id]   INT IDENTITY(1,1) NOT NULL,
    [f_name] VARCHAR(100) NULL,
    [f_source] VARCHAR(100) NULL, 
    [f_description] VARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([f_id] ASC)
);

