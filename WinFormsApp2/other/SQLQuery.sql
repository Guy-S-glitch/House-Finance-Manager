create database HouseDB;
go
use [HouseDB];

CREATE TABLE [dbo].[Houses](
[HouseNumber] nvarchar NOT NULL,
[memberName] nvarchar NOT NULL,
[Birth] [datetime] NOT NULL,
[Gender] nvarchar NOT NULL,
[Picture] nvarchar NOT NULL,
[Job] nvarchar NOT NULL,
[Experience] [int] NOT NULL,
[Salary] [int] NOT NULL,
[City] nvarchar NOT NULL,
[Phone] nvarchar NOT NULL,
[Email] nvarchar NOT NULL,
[Transport] [int] NOT NULL,
[Clothes] [int] NOT NULL,
[Sport] [int] NOT NULL,
[Market] [int] NOT NULL,
[Utilities] [int] NOT NULL,
[Rent] [int] NOT NULL,
[Restaurant] [int] NOT NULL
);