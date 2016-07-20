CREATE TABLE [dbo].[Article]
(
	[ArticleID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Title] NVARCHAR(MAX) NOT NULL, 
	[Summary] NVARCHAR(MAX) NULL,
    [Body] NVARCHAR(MAX) NOT NULL,
    [DatePublished] DATETIME NOT NULL, 
    [AuthorID] NVARCHAR(50) NOT NULL,
	CONSTRAINT [FK_ArticleAuthor] FOREIGN KEY ([AuthorID]) 
        REFERENCES [dbo].[Users] ([UserID])
)
