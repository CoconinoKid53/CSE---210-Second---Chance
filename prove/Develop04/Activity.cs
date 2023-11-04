using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected string _activityName;
    protected string _description = "";

    protected string _deepInsights = "";
   
    protected int _seconds;

    public void  DisplayGreeting() 
    {
        Console.Clear();
        // Step 1: display welcome
        Console.WriteLine($"Welcome to the {_activityName}!\n");
        // Step 2: display description
        Console.WriteLine($"{_description}\n");
        // step 3: prompt for duration
        Console.Write("How long would you like your session to last in seconds? ");
        _seconds = Int32.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
    }

    
    public void DisplaySpinner(int howlong)
    {
        for (int i=0; i<howlong; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);       
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void  DisplayCountdown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write("\b \b");
            Console.Write($"{i}");
            Thread.Sleep(1000);
        }
        Console.Write("\b \b");

    }

}

