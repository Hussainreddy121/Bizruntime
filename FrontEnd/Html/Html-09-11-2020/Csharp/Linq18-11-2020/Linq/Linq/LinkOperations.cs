using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
        public  class LinkOperations
    {
        public static void linkoperaionsOrderBY()
        {
            List<Student> list = new List<Student>()
            { 
                new Student() {studentID =2, studentName = "rajesh", marks = 90},
                new Student() {studentID = 3, studentName = "madhu", marks=87},
                new Student() {studentID = 4, studentName = "rakesh", marks=93},
                new Student() {studentID = 7, studentName = "venky", marks=67},
                new Student() {studentID = 1, studentName = "ram", marks=78},

            };

            /* var studdentDetails = from Student in list
                                   where Student.studentName.Contains('a')
                                   orderby Student.marks ascending
                                   select Student;*/

            var studdentDetails = list.Where(s => s.studentName.Contains('a')).OrderBy(s => s.marks);

            foreach (Student s in studdentDetails)
            {
                Console.WriteLine(s.studentID + "  " + s.studentName + "  " + s.marks);
            }


        }

        public static void linkoperaionsGroupBY()
        {
            List<Student> list = new List<Student>()
            {
                new Student() {studentID =2, studentName = "rajesh", marks = 90},
                new Student() {studentID = 3, studentName = "madhu", marks=87},
                new Student() {studentID = 4, studentName = "rakesh", marks=93},
                new Student() {studentID = 7, studentName = "venky", marks=78},
                new Student() {studentID = 1, studentName = "ram", marks=78},
                new Student() {studentID = 11, studentName = "ramesh", marks=90},
                new Student() {studentID = 12, studentName = "ramana", marks=91},

            };

            /*var studdentDetails = from Students in list
                                  where Students.studentName.Contains('a')
                                  group Students by Students.marks;*/

            var studdentDetails = list.Where(s => s.studentName.Contains('a')).GroupBy(s => s.marks);




            foreach (var marksgroup in studdentDetails)
            {
                Console.WriteLine(marksgroup.Key);
                foreach(Student s in marksgroup)
                {
                    Console.WriteLine(s.studentID + "  " + s.studentName + "  " + s.marks);
                }
               
            }


        }

        public static void innerjoinquery()
        {
            List<Customer> customerlist = new List<Customer>()
            {
                new Customer() {customerId =2, customerName = "rajesh", customerLocation = "majestic"},
                new Customer() {customerId = 3, customerName = "madhu", customerLocation="madiwala"},
                new Customer() {customerId = 4, customerName = "rakesh", customerLocation="BTM"},
                new Customer() {customerId = 7, customerName = "venky", customerLocation="silboard"},
                new Customer() {customerId = 1, customerName = "ram", customerLocation="madiwala"},
                new Customer() {customerId = 11, customerName = "ramesh", customerLocation="sarjapur"},
                new Customer() {customerId = 12, customerName = "ramana", customerLocation="BTM"},
            };

            List<Employee> employeeslist = new List<Employee>()
            {
                new Employee() {employeeID =12, employeeName = "ravi", employeeLocation = "majestic"},
                new Employee() {employeeID = 13, employeeName = "madhuri", employeeLocation="BTM"},
                new Employee() {employeeID = 4, employeeName = "reddy", employeeLocation="BTM"},
                new Employee() {employeeID = 71, employeeName = "varun", employeeLocation="silboard"},
                new Employee() {employeeID = 14, employeeName = "ramu", employeeLocation="madiwala"},
                new Employee() {employeeID = 1, employeeName = "ramesh", employeeLocation="sarjapur"},
                new Employee() {employeeID = 20, employeeName = "ramana", employeeLocation="BTM"},
            };


            var details = from cus in customerlist
                          join emp in employeeslist on cus.customerId equals emp.employeeID
                          select new
                          {
                              CustomerName = cus.customerName,
                              EmployeeName = emp.employeeName,
                              CustomerId = cus.customerId
                          };

                 foreach(var detail in details)
            {
                Console.WriteLine("Id "+ detail.CustomerId + "  customerName "+ detail.CustomerName + "  employeeName "+  detail.EmployeeName);
            }
              //LeftOuterJoin
            var leftjoinoperation = from cus in customerlist
                                    join emp in employeeslist
                                    on cus.customerId equals emp.employeeID into tempstorage
                                    from dg in tempstorage
                          select new
                          {
                              CustomerId = cus.customerId,
                              CustomerName = cus.customerName,

                              EmployeeName = (dg != null)? dg.employeeName : "NULL",
                              EmployeeLocation = (dg != null)? dg.employeeLocation : "Null",
                          };

            foreach (var detail in leftjoinoperation)
            {
                Console.WriteLine("Id " + detail.CustomerId + "  customerName " + detail.CustomerName + "  employeeName " + detail.EmployeeName + "employeeLocation " + detail.EmployeeLocation);
            }

            //Rightjoin
            var rightjoinoperation = from emp in employeeslist
                                     join cus in customerlist
                                    on emp.employeeID equals cus.customerId into tempstorage
                                    from dg in tempstorage
                                    select new
                                    {
                                        EmployeeID = emp.employeeID,
                                        EmployeName = emp.employeeName,

                                        CustomerName = (dg != null) ? dg.customerName : "NULL",
                                        CustomerLocation = (dg != null) ? dg.customerLocation : "Null",
                                    };

            foreach (var detail in rightjoinoperation)
            {
                Console.WriteLine("Id " + detail.EmployeeID + " employeeName " + detail.EmployeName +" customerName " + detail.CustomerName  + "employeeLocation " + detail.CustomerLocation);
            }

            // Cross Join
            var crossJoinOperation = from emp in employeeslist
                                     from cus in customerlist
                                     select new
                                     {
                                         EmployeeName = emp.employeeName,
                                         CustomerName = cus.customerName
                                     };

            foreach (var detail in crossJoinOperation)
            {
                Console.WriteLine("employeeName " + detail.EmployeeName + " customerName " + detail.CustomerName);
            }

        }



    }



    }


