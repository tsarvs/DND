CREATE TABLE [dbo].[CHARACTER_ATTACK]
(
	[a_id] INT NOT NULL , 
    [a_cid] INT NOT NULL,  
    [a_name] VARCHAR(250) NULL,
    [a_attackability] VARCHAR(25) NULL,
	[a_attackbonus] INT NULL,
	[a_isproficient] BIT NULL, 
	[a_range] VARCHAR(25) NULL,
    [a_damage1] VARCHAR(50) NULL,
	[a_damage2] VARCHAR(50) NULL, 
    [a_description] VARCHAR(MAX) NULL, 
    CONSTRAINT [FK_CHARACTER_ATTACK_ToCHARACTER] FOREIGN KEY ([a_cid]) REFERENCES [CHARACTER]([c_id]), 
    PRIMARY KEY ([a_cid], [a_id]) 
)
