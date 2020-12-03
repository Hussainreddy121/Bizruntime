var Employee = /** @class */ (function () {
    function Employee(id, name) {
        this.empid = id;
        this.empname = name;
    }
    Employee.prototype.displaydetails = function () {
        console.log(this.empid + " " + this.empname);
        return this.empid;
    };
    return Employee;
}());
var emp = new Employee(22, "madhu");
emp.displaydetails();
