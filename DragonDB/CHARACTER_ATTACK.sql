CREATE TABLE [dbo].[CHARACTER_ATTACK]
(
	[a_id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [a_cid] INT NULL, 
    [a_attackability] INT NULL,
	[a_isproficient] BIT NULL, 
	[a_range] NCHAR(10) NULL,
    [a_damage1] VARCHAR(50) NULL,
	[a_damage2] VARCHAR(50) NULL, 
    [a_itemdescription] VARCHAR(MAX) NULL, 
    CONSTRAINT [FK_CHARACTER_ATTACK_ToCHARACTER] FOREIGN KEY ([a_cid]) REFERENCES [CHARACTER]([c_id]) 
)
