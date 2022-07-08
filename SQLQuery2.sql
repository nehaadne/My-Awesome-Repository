ALTER TABLE Student
ADD email varchar(45);

select * from student;

insert into student(rollno,email) values(1,'nehaadne9@gmail.com');

ALTER TABLE Student
alter column mobile bigint;

insert into student(rollno, sname) values(2,'Sunayana');
update student set rollno=3 where sname='Sunayana'

alter table student
drop column email;

sp_help 'student';

delete from student where sname='jivan';