CREATE TABLE [dbo].[QUESTLINE] (
    [ql_id]          INT           NOT NULL,
    [q_cmpid]        INT           NOT NULL,
    [ql_title]       VARCHAR (250) NULL,
    [ql_description] VARCHAR (MAX) NULL,
    CONSTRAINT [PK_QUESTLINE] PRIMARY KEY CLUSTERED ([ql_id] ASC),
    CONSTRAINT [FK_QUESTLINE_ToCAMPAIGN] FOREIGN KEY ([q_cmpid]) REFERENCES [dbo].[CAMPAIGN] ([cmp_id])
);

