using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Listing : Activity
{
    private string _task;
    public Listing() 
    {
        _activityName = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
       
    }

public void some(string task)
        {
            _task = task;
        }

     List<string> task = new List<string>()
         {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
         };

    
     public void DoListingActivity()
    {
        DateTime CurrentTime = DateTime.Now;
        while (DateTime.Now < CurrentTime.AddSeconds(_seconds)) 
        {
            Console.Write(" Start Listing ... ");
            DisplayCountdown(5);
            Console.WriteLine();
            Console.Write("Stop Listing and take a break... ");
            DisplayCountdown(5);
            Console.WriteLine("\n");
        }

    // private string _entry;


    }
    // public override void Suga()
    // {
    //     int _entrylist = 0;
    //     time();
    //     wait(3);
    //     Console.WriteLine("List as many");
    //     Sentence1();
    //     Console.WriteLine("You may begin in");
    //     DateTime name = DateTime.Now;
         public string Questions()
    {
      int count = task.Count;
        Random question = new Random();
        int questionindex = question.Next(count);
        string List = task [questionindex];
        Console.WriteLine(List);
        return List;
    }

     public  void Answer()
     {
    
      int _entry = 0;
      DisplayGreeting();
      DisplaySpinner(2);
      Console.WriteLine("List as many repsonse for the following prompt");
      Questions();
      
      Console.WriteLine("You may being in: ");
      DisplayCountdown(5);

      DateTime  CurrentTime = DateTime.Now;
        while  (DateTime.Now < CurrentTime.AddSeconds(_seconds))
      {
        Console.ReadLine();
          _entry += 1;
        }

        DisplayCountdown(2);

        DisplaySpinner(2);

    
        Console.WriteLine($"You have listed {_entry} -items");
        Console.WriteLine($"Well done you have comlpleted another  {_seconds} of the listing Activity");
        DisplaySpinner(5);
    
     }
     
}


  
