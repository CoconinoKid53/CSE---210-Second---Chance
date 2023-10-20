using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;



partial class Program
{
    static void Main(string[] args)
    {
        Journal J1 = new Journal();
        Showsome S1 = new Showsome();
        Load L1 = new Load();
        
           
    string  Guest_Choice ="";        
    List<string> prompts = new List<string>();
    // prompts.Add("What was the important lessong you learned today?");
    // prompts.Add("What are you doing today to acheive your dreams?");
    // prompts.Add("When did you see yourself learning things and felt actually proud?");
    // prompts.Add("What is something you think everyone should struggle with in life?");
    // prompts.Add("What will you do someone would not struggle like you did?");



while(Guest_Choice != "5" )
{
    
    Console.WriteLine("1. write a new journal entry"); // display ui
    Console.WriteLine("2. Display Journal entry");
    Console.WriteLine("3.Load journal Entry");
    Console.WriteLine("4. Save journal entry ");
    Console.WriteLine("5. Quit");
    Console.WriteLine("What option would you like to choose?");
    Guest_Choice = Console.ReadLine()??string.Empty;
    

        // string Guest_Choice = Console.ReadLine();

    if (Guest_Choice== "1")
    {
        S1.WritePrompt();
        J1.Entries.Add(S1);
        
    }

    else if(Guest_Choice == "2")
    {
        S1.Display();
        Console.WriteLine("test 2");
    }

    

     else if (Guest_Choice == "3")
     {
        List<Showsome> Load = L1.star();
        J1.Load_Entry(Load);
        J1.Log();
  
     }

    else  if (Guest_Choice == "4")
     {
        L1.scriptname(J1.entries1());
        Console.WriteLine("Congratioulations you saved");
     }

     
        

}

// List<Motivation> motivations = new List<Motivation>();
//  Entry2.entry = new Entry2();
//  Entry2.entry =  Partial save Entry2();
 


 
    // public string EntryDate { get; set} Note to write getters and setters




    // save to file

    }
}
    //public static void  SaveToFile(List<)