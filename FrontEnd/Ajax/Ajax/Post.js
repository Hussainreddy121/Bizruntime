function loadpage()
{
    var xhttp = new XMLHttpRequest();
   
    xhttp.open("POST", "Samplepost.txt", true);
    xhttp.setRequestHeader("Content-Type",  "application/json");
    xhttp.onreadystatechange = function()
    {
        if(this.readyState == 4 || this.status == 200)
        {
               alert("Connection established");
        }
        else
        {
            alert("error on page");
        }
    }
    let data = {"fname=Henry&lname=Ford":"fname=Henry&lname=Ford"};
    xhttp.send(data);
}