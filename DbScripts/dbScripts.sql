Create Database Student
use Student

--drop table Student
create Table Student
(
 Id int identity(1,1),
 Name Varchar(500) not null ,
 EmailId Varchar(500) unique  not null,
 Password varchar (100) not null
)

insert into Student(name,EmailId,Password) values ('Devesh','Devesh123@gmail.com','niit@123')
insert into Student(name,EmailId,Password) values ('Vivek','vivek123@gmail.com','fdf@123')
insert into Student(name,EmailId,Password) values ('Kuldeep','kuldeepgole@gmail.com','gfg@123')
insert into Student(name,EmailId,Password) values ('Shyam','shyam.89@gmail.com','g@1gfg23')
insert into Student(name,EmailId,Password) values ('Prabhat','prabhat.78@gmail.com','niigfgt@ggd123')


Create Procedure Sel_Student
as
(
select Id, name,EmailId,Password from Student
)


-- 
exec Sel_Student


select * from Student
