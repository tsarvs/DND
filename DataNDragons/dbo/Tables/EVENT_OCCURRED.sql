CREATE TABLE [dbo].[EVENT_OCCURRED] (
    [eo_id]    INT           NOT NULL,
    [eo_lid]   INT           NULL,
    [eo_desc]  VARCHAR (MAX) NULL,
    [eo_start] DATETIME      NULL,
    [eo_end]   DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([eo_id] ASC),
    CONSTRAINT [FK_EVENT_OCCURRED_ToLOCATION] FOREIGN KEY ([eo_lid]) REFERENCES [dbo].[LOCATION] ([l_id])
);

