CREATE DATABASE ASSIGNMENT;
CREATE TABLE Person(
   PersonID int,
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
	PRIMARY KEY(PersonID)
);
select * from Person;

CREATE TABLE Doctor(
    Did int,
    dname varchar(255),
    daddress varchar(255),
    qualification varchar(255),
    noofpatient_handled varchar(255)
);
select * from Doctor;
/*9.	write a query to insert 5 records into the Doctor table*/

insert into Doctor values(01, 'Neha','pune','MBBS','abc');

CREATE TABLE PatientMaster(
    Pcode int,
    pname varchar(255),
    paddr varchar(255),
	age int,
    gender varchar(255),
    bloodgroup varchar(255)
);
select * from PatientMaster;

CREATE TABLE AdmittedPatient(
    Pcode int,
    Entry_date datetime,
	Discharge_date datetime,
    wardno int,
	disease varchar(255),
);
select * from AdmittedPatient;

CREATE TABLE Bill(
    BillNo int,
    Pcode int,
	bill_amount float,
);
select * from Bill;

/*5.	write a query to change the data type ward no int to varchar(10)*/
CREATE TABLE AdPatient(
    Pcode int,
    Entry_date datetime,
	Discharge_date datetime,
    wardno varchar(10),
	disease varchar(255),
);
select * from AdPatient;

/*8.	write a query to add primary key to patientMaster*/
CREATE TABLE PMaster(
    Pcode int,
    pname varchar(255),
    paddr varchar(255),
	age int,
    gender varchar(255),
    bloodgroup varchar(255),
	PRIMARY KEY(Pcode)

);
select * from PMaster;

