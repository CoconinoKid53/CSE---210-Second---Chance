using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Reflection : Activity
{
    private string _reflect;
    private string _starting;
    public Reflection()
    {
        _activityName = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    //   _Instruction = "";
    }

    public void DoReflectionActivity()
    {
      
        Console.Write("Begin thinking of the prompt... ");
        DisplayCountdown(5);
        Console.WriteLine();
        Console.Write("stop thinking and take a Breath ...");
        DisplayCountdown(5);
        Console.WriteLine("\n");
       
  
    }
  
    public void Mirror( string starting,  string reflect)
    {
        _starting = starting;
        _reflect = reflect;
    }
    public string Random()
    {
      int count = reflect.Count;
        Random question = new Random();
        int questionindex = question.Next(count);
        string List = reflect[questionindex];
        Console.WriteLine(List);
        return List;
    }
    List<string> reflect = new List<string>(){
    "What was the important lesson you learned today?",
    "What are you doing today to acheive your dreams?",
    "When did you see yourself learning things and felt actually proud?",
    "What is something you think everyone should struggle with in life?",
    "What will you do someone would not struggle like you did?"};



    List<string> starting = new List<string>(){
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless."
    };

    public string Questions()
    {
      int count = starting.Count;
        Random question = new Random();
        int questionindex = question.Next(count);
        string List = starting [questionindex];
        Console.WriteLine(List);
        return List;
    }

     public  void Answers()
     {
      DisplayGreeting();
      DisplaySpinner(5);
      Questions();
      Console.ReadLine();
      DisplayCountdown(5);
      Random();
      Console.WriteLine("Press Enter to Continue");
      Console.Write("When you something in mind, press continue to enter");
      
      DateTime  CurrentTime = DateTime.Now;
        if  (DateTime.Now < CurrentTime.AddSeconds(_seconds))
      { 
        Console.WriteLine("You may being in: ");
        DisplayCountdown(5);

      Random();
      DisplaySpinner(5);
      Random();
      DisplaySpinner(5);
      Console.WriteLine("Congratulations");
      Console.WriteLine($"You have completed another {_seconds}seconds");
      DisplaySpinner(5);
      }
     }
     
}
