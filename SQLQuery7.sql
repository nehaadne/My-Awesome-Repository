create table batch
(
batchid int,
batchname varchar(25),
startdate date,
trainerid int,

mobile bigint,
);

select GETDATE();
SELECT CURRENT_TIMESTAMP;
SELECT CURRENT_USER;
SELECT DAY(getDATE());
select DATENAME(dw,getDATE());
select DATEDIFF(year,'1998-7-11',GETDATE());

use HR;

select * from employees;

select CONCAT('Mr.',first_name,'-',last_name) as Fullname from employees;

select upper(first_name),len(first_name) from employees;

select first_name, len(trim(first_name)) from employees;

update employees
set first_name=trim(first_name);
select SUBSTRING(first_name,1,3) from employees;
select ASCII('A');
SELECT CHAR(67);
SELECT REPLICATE('JIVAN',10);

