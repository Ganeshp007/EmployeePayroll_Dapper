create database Employeepayroll_Dapper

use Employeepayroll_Dapper

create table Employee(
EmpId INT PRIMARY KEY IDENTITY	NOT NULL,
Firstname varchar(25) NOT NULL,
Lastname varchar(25) NOT NULL,
Address varchar(70),
MobileNo bigint,
)
exec sp_columns Employee --to describe table

insert into Employee(Firstname,Lastname,Address,MobileNo) values('Ganesh','Potdar','Kothrud,pune.',9511949586)
insert into Employee(Firstname,Lastname,Address,MobileNo) values('Rohan','Pande','Shivaji nagar,pune.',7741891991)

select * from Employee
