class Employee
{
   empid: number;
   empname: string;

   constructor(id: number, name: string)
   {
       this.empid = id;
       this.empname = name;
   }

   displaydetails() : number
   {
       console.log(this.empid + " " + this.empname)
       return this.empid;
   }
  
}
var emp = new Employee(22, "madhu");
emp.displaydetails();
