CREATE TABLE Information (
ID INT NOT NULL IDENTITY(1, 1), 
FirstName VARCHAR(100) NULL,
LastName VARCHAR(100) NULL,
Phone VARCHAR(20) NULL,
Email VARCHAR(100) NULL,

PRIMARY KEY(ID)
);

SELECT * FROM Information;

USE [UserDatabase];
EXEC SP_RENAME 'dbo.Input', 'Information';