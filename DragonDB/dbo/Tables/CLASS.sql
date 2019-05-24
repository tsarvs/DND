CREATE TABLE [dbo].[CLASS]
(
	[cl_id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [cl_name] VARCHAR(50) NULL, 
    [cl_hitdicetype] VARCHAR(10) NULL, 
    [cl_spellcastingability] VARCHAR(10) NULL
)
