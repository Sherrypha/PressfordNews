CREATE TABLE [dbo].[Likes]
(
	[UserID] NVARCHAR(50) NOT NULL,
	[ArticleID] INT NOT NULL ,
	[LikeId] INT NOT NULL  iDENTITY(1,1), 
	 CONSTRAINT [FK_UserLike] FOREIGN KEY ([UserID]) 
        REFERENCES [dbo].[Users] ([UserID]),
    CONSTRAINT [FK_ArticleLike] FOREIGN KEY ([ArticleID]) 
        REFERENCES [dbo].[Article]([ArticleID]),		
    PRIMARY KEY(LikeId,UserID,ArticleID)

)
