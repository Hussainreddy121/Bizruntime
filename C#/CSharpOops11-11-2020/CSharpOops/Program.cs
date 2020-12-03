using System;

namespace CSharpOops
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodOverloading methodOverloading = new MethodOverloading();
            methodOverloading.add(5, 45);
            methodOverloading.add(0.9f, 4.6f);

            CompanyDetails cd = new CompanyDetails();
            Console.WriteLine("id of employee " + cd.id);
            cd.employeeName();
            Console.WriteLine("Salary " + cd.salary);
            cd.employeeSkills();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Dog();

            VehicalDetails vehicalDetails = new VehicalDetails();
            vehicalDetails.vehicle();
            vehicalDetails.vehicleType();

            Encapsulation encapsulation = new Encapsulation();
            encapsulation.id = 202;
            encapsulation.name = "ramesh";
            encapsulation.mobileNo = 8768686767;

            Console.WriteLine(encapsulation.id);
            Console.WriteLine(encapsulation.name);
            Console.WriteLine(encapsulation.mobileNo);

            compilePolymorphism.comiplepolymrphsim();

            Runtimepolymorphsim rp = new Runtimepolymorphsim();
            rp.runtimepolymorphsim();


        }
    }
}
