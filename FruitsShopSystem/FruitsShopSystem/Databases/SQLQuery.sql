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

CREATE TABLE [Transaction](
Transaction_ID VARCHAR(5) NOT NULL,
Fruit_Name VARCHAR(50) NOT NULL,
Total_Fruits INT NOT NULL,
Total_Price DECIMAL NOT NULL,
Time_Transaction TIME NOT NULL,
Date_Transaction DATE NOT NULL,

PRIMARY KEY(Transaction_ID)
);

-- Select Database
SELECT * FROM [UserAccount];
SELECT * FROM [Transaction];

SELECT Name, Email, Password FROM [UserAccount] WHERE ID = 3;

-- Delete
DROP TABLE [UserAccount];
DROP Table [Transaction];
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