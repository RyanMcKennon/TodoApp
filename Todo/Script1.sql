create database Todo;
go

use Todo;
go
create schema List;
go


--create the table by using the schema, and the table name followed by a dot
create table List.List
(
    ItemID int identity(1,1) primary key,
    ItemName nvarchar(max),
	Completed bit not null
);
go

select * from List.List;

insert into List.List(ItemName,Completed) values ('work', 0);
