using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOops
{
    public class InheritancePogram
    {
        public int id;
        public void employeeName()
        {
            Console.WriteLine("Employee Name Ramesh");
        }
    }
    public class CompanyDetails : InheritancePogram
    {
        public long salary;

        public void employeeSkills()
        {
            Console.WriteLine("Skills of employee C#");
        }
    }
}
