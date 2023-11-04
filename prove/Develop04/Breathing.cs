using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Breathing : Activity
{
    public Breathing(){
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void DoBreathingActivity()
    {
        DateTime CurrentTime = DateTime.Now;
        while (DateTime.Now < CurrentTime.AddSeconds(_seconds)) 
        {
            Console.Write("Breathe in... ");
            DisplayCountdown(5);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            DisplayCountdown(5);
            Console.WriteLine("\n");
        }
    }
}