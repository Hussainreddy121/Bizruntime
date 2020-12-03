using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace Json
{
    public class SerializationEx
    {

        public static void serializationmethod()
        {
            Employee employee = new Employee();
            employee.id = 21;
            employee.name = "madhu";
            employee.address = "Bangalore";
            employee.languagelist = new List<string> { "c", "C++", "C#", "Java", "Css" };


            String result = JsonConvert.SerializeObject(employee);
            Console.WriteLine(result);

            Employee deresult = JsonConvert.DeserializeObject<Employee>(result);

            Console.WriteLine(deresult.id); 
            Console.WriteLine(deresult.name);
            Console.WriteLine(deresult.address);
            List<string> deser = new List<string>(deresult.languagelist);
            Console.WriteLine(String.Join(",", deser));

        }
    }
    class Employee
    {
        public int id { get; set; }
        public string name { get; set;}
        public string address { get; set; }

        public List<string> languagelist { get; set; }
    }
}
