CREATE TABLE [dbo].[Customer] (
    [CustomerID] INT                IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (25)      NOT NULL,
    [LastName]   NVARCHAR (25)      NOT NULL,
    [CreatedUtc] DATETIMEOFFSET (7) NOT NULL,
    [SocialSecurityNumber] INT NULL, 
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);

