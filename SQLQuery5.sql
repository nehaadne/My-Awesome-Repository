select * from employees where salary>10000 and department_id=9;

select * from employees where department_id=1 or department_id=3 or department_id=5;

select * from employees where department_id in (1,3,5);

select * from employees where department_id not in (1,3,5);

select * from employees where salary>=10000 and salary<=20000;

select * from employees where salary between 10000 and 20000;

select * from employees;

select * from employees where phone_number is null;

select * from employees where phone_number is not null;

--wildcard characters %===>means 0 or more
-- _ means single character
-- whenever we use wildcharcters for pattern matching we use like operator not =

select * from employees where first_name like 'D%';

select * from employees where first_name like 'D____';

select * from employees where first_name like '%a%';

select * from employees where first_name like '__a__';

select * from employees where first_name like '__r__';

-- list all employees ending with n

select * from employees where first_name like '%n';

--list all emp whose 2nd character is a
select * from employees where first_name like '_a%';


--sorting (using order by)

select * from employees order by first_name;

select * from employees order by first_name desc;

--aggregate function
--min, max, sum, avg

select max(salary) from employees;

select min(salary) from employees;

select sum(salary) from employees;



--group by

select department_id,max(salary) from employees group by department_id;

select department_id,count(*) as 'EmplyoeeCount' from employees group by department_id;

--temporary column
select first_name, salary, salary+5000 as 'Incremented salary' from employees;

--find IT department employess
select * from employees where department_id=6;

--Subquery

select * from employees where department_id=
(select department_id from departments where department_name='IT');

--Joins
--cross join
--inner join

select first_name, department_name from employees inner join departments on employees.department_id=departments.department_id;

select first_name, department_name,city from employees e inner join departments d on e.department_id=d.department_id 
inner join locations l on l.location_id=d.location_id;

create table emp
(
empid int primary key identity(1,1),
ename varchar(25),
salary int,
managerid int
);

alter table emp
add constraint fkmgridd foreign key(managerid) references emp(empid);

insert into emp(ename,salary,managerid) values('meera',100000,4);

select * from emp;

select e.ename,m.ename from emp e inner join emp m on e.managerid=m.empid;