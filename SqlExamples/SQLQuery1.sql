create table studentS(Id INT,
                      Name Varchar(50),
					 marks int,
					 location Varchar(50))

insert into students (id, Name, marks, location) values(2, 'ramesh', 78, 'bangalore');
insert into students (id, Name, marks, location) values(3, 'ravi', 87, 'andhra');
insert into students (id, Name, marks, location) values(32, 'mahesh', 99, 'bangalore');
insert into students (id, Name, marks, location) values(5, 'madhu', 67, 'btm');
insert into students (id, Name, marks, location) values(6, 'ramu', 78, 'slikboard');
insert into students (id, Name, marks, location) values(8, 'varun', 97, 'madiwala');
insert into students (id, Name, marks, location) values(2, 'manasa', 89, 'btm');
insert into students (id, Name, marks, location) values(2, 'rakesh', 67, 'agara');

select * from students;

select * from students where id = 3;

select * from students where id = 3 and marks=87;

select * from students where id = 3 or marks=100 or location = 'andhra';

select * from students where marks Between 75 AND 98 order by marks Desc;

select name, id from students order by name, id;

select * from students order by id, name offset 2 rows fetch next 4 rows only;

insert into students (id, Name, marks, location) values(8,'varun', 89, 'btm');

select distinct * from students;

select * from students where id in(2,4) order by marks desc;

select count(id), id from students group by id;

select * from students;


create table Teachers(id int, names varchar(50), gender varchar(20), locations varchar(50));


insert into Teachers (id, names, gender, locations)
                  values
				  (1, 'Ramesh', 'male', 'bangalore'),
				  (11, 'ravi', 'male', 'btm'),
				  (3, 'latha', 'female', 'bangalore'),
				  (12, 'mahesh', 'male', 'agara'),
				  (22, 'manasa', 'female', 'nandyal'),
				  (3, 'bhaskar', 'male', 'vizag'),
				  (2, 'ismail', 'male', 'ongole'),
				  (13, 'vijaya', 'female', 'nandyal'),
				  (1, 'israel', 'male', 'andhra');


select * from Teachers;

select s.id, s.name, s.marks, t.id, t.names from studentS s
                                         inner join Teachers t
                                         on s.id = t.id;
 
 select s.id, s.name, t.id, t.names from studentS s
                                      left join Teachers t
									  on s.Name = t.names
									  order by s.id;

select s.id, s.name, t.id, t.names from  Teachers t
                                      right join studentS s
									  on s.Name = t.names
									  order by s.id;

select s.id, s.name, t.id, t.names from  Teachers t
                                      full outer join studentS s
									  on s.Name = t.names
									  order by s.id;

select id, name from studentS Union select id, names from Teachers;

select id, name from studentS intersect select id, names from Teachers;

select id, name from studentS except select id, names from Teachers;

SELECT  CURRENT_TIMESTAMP AS current_date_time;


	Begin
	 select names from Teachers where id between 1 And 5;

	 if @@ROWCOUNT >1
	 PRINT 'we have rows between 1 and 5';
	end

	Declare @counter int = 1;
	while(@counter <5)
	begin 
	print @counter;
	set @counter = @counter + 1;
	end


	create table employee(id int, ename varchar(50), email varchar(50), ework varchar(20));

	drop  table employee;

	create table employee(id int primary key, ename varchar(50) not null, email varchar(50), ework varchar(20));

	insert into employee (id, ename, email, ework)
	            values(1, 'mahesh', 'mahesh@gmail.com', 'dev'),
				      (2, 'madhu', 'madhuh@gmail.com', 'tester'),
					  (5, 'ismail', 'ismail@gmail.com', 'infra'),
					  (23, 'israel', 'israel@gmail.com', 'hr'),
					  (11, 'hussain', 'hussain@gmail.com', 'dev'),
					  (12, 'rasi', 'rasi@gmail.com', 'dev'),
					  (18, 'murthy', 'murthy@gmail.com', 'tester'),
					  (31, 'naresh', 'naresh@gmail.com', 'infra');

	select * from employee;

	create table customer(cid int primary key, cname varchar(50) not null, ework varchar(20), no int unique);

	insert into customer (cid, cname, ework, no)
	            values(11, 'bhaskar', 'sales', '73722'),
				      (21, 'manoj', 'sales excutive', '98890'),
					  (53, 'bhupathi', 'sales man', '67897'),
					  (3, 'sheshu', 'sales', '87332'),
					  (911, 'prasad', 'manager', '34532'),
					  (2, 'kohli', 'asistant manager', '74743'),
					  (8, 'sheshu', 'sales excutive', '96344'),
					  (321, 'naresh', 'assistant manager', '23457');

		select * from customer;



	select * from employee where id in(select cid from customer);

	select * from customer where cname = any( select ename from employee);

	select top 2 id, ename, ework from employee;
	                                   