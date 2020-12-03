
        CREATE PROCEDURE  studentdetails 
As	
	 begin 
	  select id, marks
	  from dbo.student 
	  order by marks;
	  end;


	 
	 exec studentdetails;

	