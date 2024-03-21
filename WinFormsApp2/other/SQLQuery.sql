create database HouseDB;
go
use [HouseDB];

CREATE TABLE [dbo].[Houses](
[HouseNumber] nvarchar(50) NOT NULL,
[memberName] nvarchar(50) NOT NULL,
[Birth] [datetime] NOT NULL,
[Gender] nvarchar(50) NOT NULL,
[Picture] nvarchar(255) NOT NULL,
[Job] nvarchar(50) NOT NULL,
[Experience] [int] NOT NULL,
[Salary] [int] NOT NULL,
[City] nvarchar(50) NOT NULL,
[Phone] nvarchar(50) NOT NULL,
[Email] nvarchar(50) NOT NULL,
[Transport] [int] NOT NULL,
[Clothes] [int] NOT NULL,
[Sport] [int] NOT NULL,
[Market] [int] NOT NULL,
[Utilities] [int] NOT NULL,
[Rent] [int] NOT NULL,
[Restaurant] [int] NOT NULL
);