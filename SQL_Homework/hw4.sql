create table Products (
 Id int primary key identity,
 Name nvarchar(100) check(Name > '') not null,
 Type nvarchar(100) check(Type > '') not null,
 Count int not null,
 Cost int check(Cost > 0) not null,
 Manufacturer nvarchar(100) not null,
 RetailPrice int not null
)

create table Sales (
 Id int primary key identity,
 Name nvarchar(100) check(Name > '') not null,
 Cost int check(Cost > 0) not null,
 Amount int check(Amount > 0) not null,
 --Date date not null,
 SellerInfo nvarchar(100) not null,
 BuyerInfo nvarchar(100) not null,
)

create table Outbox ( 
 Id bigint primary key identity,
 EventType varchar(500) not null,
 Message nvarchar(max) not null,
)
--drop table Products
--drop table Sales
--drop table Outbox
--drop trigger SalesMade

INSERT INTO SALES(Name, Cost, Amount, SellerInfo, BuyerInfo)
VALUES('o', 1, 2, 'a', 'b')

go
create trigger SalesMade
on Sales
after insert
as

declare @Message nvarchar(max);
set @Message = (
 select 
  Id as [Id],
  Name as [Name],
  Cost as [Cost],
  Amount as [Amount],
  SellerInfo as [SellerInfo],
  BuyerInfo as [BuyerInfo]
 from inserted
 for json path
);

insert into Outbox(EventType, Message)
values('Sale', (select JSON_QUERY(@Message) as sales for json path, without_array_wrapper))

go

select * from Outbox