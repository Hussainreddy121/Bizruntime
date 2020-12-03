   CREATE PROCEDURE  studentdetails(@maxmarks int) 
As	
	 begin 
	  select id, marks
	  from dbo.student where marks = @maxmarks
	  order by marks;
	  end;


	 
	 exec studentdetails 90;