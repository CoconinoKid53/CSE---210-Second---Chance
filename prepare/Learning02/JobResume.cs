using System;
using System.ComponentModel;
using System.Security.AccessControl;

public class Resume{
   public List <Job> _jobs = new List<Job> () {
 };

   public string employee = "Dillon";
   public  string _jobTitle2 = "Software Engineer";

   public string _companyName = "Amazon";

   public string _companyName2 = "Audi";

   public int _startYear = 2023;

   public int _endYear = 2025;

   
   

   
   
       public void Display()
       {
         Console.WriteLine($"employee:{employee}");
         Console.WriteLine("jobs:");

         foreach( Job  job in  _jobs)
         {
            job.Display();
         }
   
   
    
      
    
}
   

       }

    
   

    
       
                        