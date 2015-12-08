create database ProductDB
use ProductDB
create table Product
(
PID int primary key identity (1001,1),
BrandName nvarchar (50),
PCatagory nvarchar (50),
Details nvarchar (MAX),
Price decimal (10,2),
Stock int,
NoOfIteam int,
PType nvarchar (50)
)