-- Create Database
CREATE DATABASE [FruitsShop];

-- Create Table
CREATE TABLE [UserAccount](
[ID] INT NOT NULL IDENTITY(1, 1),
[Name] VARCHAR(250) NOT NULL,
[Email] VARCHAR(250) NOT NULL,
[Password] NVARCHAR(200) NOT NULL,

PRIMARY KEY(ID)
);

-- Select Database
SELECT * FROM [UserAccount];
SELECT * FROM [Transactions];

-- Delete
DROP TABLE [UserAccount];
DROP DATABASE [FruitsShop];

-- Getting Database information
SELECT ORDINAL_POSITION, COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'UserAccount';

SELECT CONSTRAINT_NAME
FROM INFORMATION_SCHEMA.CONSTRAINT_TABLE_USAGE
WHERE TABLE_NAME = 'UserAccount';

SELECT name, type_desc, is_unique, is_primary_key
FROM sys.indexes
WHERE [object_id] = OBJECT_ID('dbo.UserAccount');

DELETE FROM [UserAccount]
WHERE [ID] = 1;