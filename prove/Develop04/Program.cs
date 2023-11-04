using System;

public class Program
{
    static void Main(string[] args)
    {
        string Guest_Choice = "";
        while (Guest_Choice != "4")
        {
            Console.Clear();
            Console.WriteLine("1. Start Breathing Activity"); // display ui
            Console.WriteLine("2. Start Reflecting Activity ");
            Console.WriteLine("3. Start Listing Activity ");
            Console.WriteLine("4. Quit");
            Console.WriteLine("What option would you like to choose?"); // end
            Guest_Choice = Console.ReadLine();

            if (Guest_Choice == "1")
            {
                Breathing breathing = new Breathing();
                breathing.DisplayGreeting();
                breathing.DisplaySpinner(3);
                breathing.DoBreathingActivity();
            }

            else if(Guest_Choice == "2")
            {
                Reflection reflecting = new Reflection();
                
                reflecting.Answers();
            }
            
            else if (Guest_Choice == "3") 
            {
                Listing listing = new Listing();
                listing.Answer();
        }
     
    }
}
}