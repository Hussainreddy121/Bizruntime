abstract class student {
    studentid: number;

    constructor(id: number)
    {
        this.studentid = id;
    }

   abstract detailsStudent(): number;

}

class College extends student
{
    studentname: string;
      
    constructor(id: number, name: string)
    {
         super(id);
         this.studentname = name;
    }
     detailsStudent(): number
     {
       console.log(this.studentid + " " + this.studentname);
       return this.studentid;
     }

   
      
}

var s: College = new College(12, "manoj");
s.detailsStudent();