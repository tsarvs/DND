CREATE TABLE [dbo].[EPISODE] (
    [ep_id]    INT           NOT NULL,
    [ep_cmpid] INT           NOT NULL,
    [ep_date]  DATE          DEFAULT (getdate()) NULL,
    [ep_desc]  VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([ep_id] ASC),
    CONSTRAINT [FK_EPISODE_ToCAMPAIGN] FOREIGN KEY ([ep_cmpid]) REFERENCES [dbo].[CAMPAIGN] ([cmp_id])
);

