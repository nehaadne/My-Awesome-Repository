use SHAURYATRAINNING;

--non clustered
--create index idxsl on emp(salary);

--select * from emp where salary>30000;

alter table student
add email varchar(25);

create unique index idxmail on trainer(email)
where email is not null;

select * from student;
insert into student(sname,city) values('mansi','nashik');

select * from employees e1 where salary>=(select avg(salary) from employees e2 where
e2.department_id=e1.department_id);

--union all (merge keep duplicates)
--union unique (remove duplicates)

select empid,ename from emp
union all
select employee_id,first_name from employees
 
select empid,ename from emp
union 
select employee_id,first_name from employees

