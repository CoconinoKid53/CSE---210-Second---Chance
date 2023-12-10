using System;
using System.Diagnostics.Contracts;
using System.Runtime.Versioning;

class Program
{
    static  List <Activity> activities;

    static void Main(string[] args)
    {
        Swimming swimming = new Swimming(15, 10);
        Running running = new Running(30, 5);
        Cycling cycling = new Cycling (30,5,1);
        activities = new List<Activity>() {
            swimming,running,cycling
        };
        foreach(Activity activity in activities){
            System.Console.WriteLine (activity.GetSummary1());
            
        }
    }
}