create table author
(
authorid int primary key,
authorname varchar(50),
);

create table book
(
bid int primary key,
bookname varchar(25),
aid int,
constraint fkaid foreign key(aid) references author(authorid)
);