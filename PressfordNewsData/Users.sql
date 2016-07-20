CREATE TABLE [dbo].[Users]
(
	[UserID] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [EmailAddress] NVARCHAR(50) NULL, 
    [PublisherRights] BIT NULL
)
