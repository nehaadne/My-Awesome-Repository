use SHAURYATRAINNING;

create table book
(
bid int,
authorname varchar(30),
)

begin try
begin transaction
insert into author values(101, 'neha');
insert into book values(102, 'c#', 23);
commit transaction;

end try
begin catch
rollback transaction;
end catch;

--auto increment
create table trainer
(
tid int primary key identity(1,1),
tname varchar(25),
exper int
);

insert into trainer(tname) values('Deepa mam'),('Medha mam'),('Kirti mam');

select * from trainer;
