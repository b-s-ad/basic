create database Employee use Employee

create table Employee(
EmployeeID int,
Employee_Name varchar(100),
Age int,
Salary int,
Gender varchar(20),

);

insert into Employee (EmployeeID,Employee_Name,Age,Salary,Gender)values(1,'ABC',24,5000,'M');
insert into Employee (EmployeeID,Employee_Name,Age,Salary,Gender)values(11,'ABCD',524,65000,'M');
insert into Employee (EmployeeID,Employee_Name,Age,Salary,Gender)values(12,'ABCE',624,95000,'M');
insert into Employee (EmployeeID,Employee_Name,Age,Salary,Gender)values(123,'ABCE',724,85000,'M');
insert into Employee (EmployeeID,Employee_Name,Age,Salary,Gender)values(14,'ABCF',824,65000,'M');
insert into Employee (EmployeeID,Employee_Name,Age,Salary,Gender)values(15,'ABCJ',924,55000,'M');
insert into Employee (EmployeeID,Employee_Name,Age,Salary,Gender)values(16,'ABCK',624,45000,'M');
insert into Employee (EmployeeID,Employee_Name,Age,Salary,Gender)values(17,'ABCL',524,35000,'M');
insert into Employee (EmployeeID,Employee_Name,Age,Salary,Gender)values(18,'ABCP',4424,25000,'M');
insert into Employee (EmployeeID,Employee_Name,Age,Salary,Gender)values(19,'ABCO',5524,15000,'M');

select * from Employee

//Go
//
create procedure spGetEmp
as
begin
select EmployeeID,Employee_Name,Age from Employee
end

//
begin
select * from Employee
end