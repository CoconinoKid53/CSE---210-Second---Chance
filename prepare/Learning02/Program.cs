using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        Job job3 = new Job();
        job1._companyName = "Audi";
        job2._companyName = "Amazon";
        job1._startYear = 2027;
        job1._endYear = 2030;
        job2._startYear = 2022;
        job2._EndYear3 = 2025;

        Resume employee1 = new Resume();
        employee1.employee = "Dillon";
        Console.WriteLine(employee1.employee);
        Console.WriteLine(job1._companyName);
        Console.WriteLine(job1._startYear);
        Console.WriteLine(job1._endYear);
        Console.WriteLine(job2._companyName);
        Console.WriteLine(job2._startYear);
        Console.WriteLine(job2._EndYear3);

    }
}