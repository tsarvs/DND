﻿CREATE TABLE [dbo].[CHARACTER_CLASS]
(
	[cc_cid] INT NOT NULL , 
    [cc_clid] INT NOT NULL, 
    [cc_level] INT NULL DEFAULT 1, 
    [cc_hitdice_current] INT NULL, 
    PRIMARY KEY ([cc_clid], [cc_cid]), 
    CONSTRAINT [FK_CHARACTER_CLASS_ToCHARACTER] FOREIGN KEY ([cc_cid]) REFERENCES [CHARACTER]([c_id]), 
    CONSTRAINT [FK_CHARACTER_CLASS_ToCLASS] FOREIGN KEY ([cc_clid]) REFERENCES [CLASS]([cl_id])
)
