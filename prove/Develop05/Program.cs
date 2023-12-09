using System;

class Program
{

    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string guestChoice = "";
        while (guestChoice != "6")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create new Goal"); // display ui
            Console.WriteLine("   2. List Goals ");
            Console.WriteLine("   3. Save Goals ");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            guestChoice = Console.ReadLine();

            // Interpret user input
            if (guestChoice== "1")
            {
                // Create Goals
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("   1. Simple Goal");
                Console.WriteLine("   2. Eternal Goal");
                Console.WriteLine("   3. Checklist Goal");
                Console.Write("What type of goal would you like to create? ");
                string choice = Console.ReadLine();

                
            

                if (choice == "1") 
                {
                    // I need to make a new SimpleGoal object
                    goalManager.CreateSimpleGoal();
                }
                else if( choice == "2")
                {
                    goalManager.CreateEternalGoal();
                }
                else if( choice == "3")
                {
                    goalManager.CreateChecklistGoal();
                }
                goalManager.ShowRecentGoal();
            }
            else if(guestChoice == "2")
            {       
                // List Goals
                goalManager.DisplayGoals();
            }
            else if (guestChoice == "3")
            {
                // Save Goals
            }
            else  if (guestChoice == "4")
            {
                // Load Goals
            }
            else if (guestChoice == "5")
            {
                // Record event
                goalManager.DisplayGoals();
                goalManager.CompleteGoal();
            }
        }
        
    }
}