CREATE TABLE [dbo].[ITEM] (
    [i_id]     INT IDENTITY(1,1) NOT NULL,
	[i_cid] INT NOT NULL,
	[i_name] VARCHAR(250) NULL,
	[i_quantity] INT NULL,
    [i_weight] DECIMAL (18) NULL,
    [i_description] VARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([i_cid], [i_id]), 
    CONSTRAINT [FK_ITEM_ToCHARACTER] FOREIGN KEY ([i_cid]) REFERENCES [CHARACTER]([c_id])
);

