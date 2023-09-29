using System;
using System.ComponentModel.DataAnnotations;



public class Job{
     
    public string _jobTitle = "Software Engineer";

    public string _companyName = "Amazon";

    public string _jobTitle2 = "Automotive Security Engineer";

    public string _companyName2 = "Audi";

    public int _startYear = 2022;

    public int _endYear = 2025;
    
    public int _startYear2 = 2027;

    public int _EndYear3 = 2030;
    


    public void Display()
    {
        Console.WriteLine("${_jobTitle}, {_jobTitle2},  {_CompanyName}, {companyName2}, {_startYear}, {_endYear}, {_startYear2}, {_endYear3}");
    }

}