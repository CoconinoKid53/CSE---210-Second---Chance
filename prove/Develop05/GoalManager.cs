using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    public void LoadGoals()
    {
        // logic for parsing file into List<Goal>
        // (e.g. List<Goal> tempList = whatver logic you have)

        // DONT'T ADD TO _goals, REPLACE _goals. i.e.
        // _goals = tempList
    }
    private  List<Goal> _goals = new List<Goal>();

    private int points = 0;

       public void ShowRecentGoal()
        {
       Console.WriteLine(_goals.Last().Display());
            
        }

     public void UserCompleteGoal()
      {
        DisplayGoals();
        Console.WriteLine("Which goal have you completed? Choose goal number");
        string  goalNumber = Console.ReadLine(); 
       int index = int.Parse(goalNumber);
        _goals[index - 1].MarkCompleted();
        
     }

     public void DisplayGoals() {
           
            Console.Clear();
            Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            System.Console.WriteLine($"{i + 1}. {_goals[i].Display()}\n");
        }                

        System.Console.WriteLine($"You currently have {points} points!");
    }
         public void CreateSimpleGoal()
         {
             SimpleGoal s1 = new SimpleGoal(); //  SimpleGoal object
                    s1.SetGoalName(); // get the name of the goal from the user
                    s1.SetGoalDescription();
                    s1.SetGoalPoints();
                    _goals.Add(s1);
         }

         public void CreateEternalGoal()
    {
        EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.SetGoalName();
                    eternalGoal.SetGoalDescription();
                    eternalGoal.SetGoalPoints();
                    _goals.Add(eternalGoal);
    }

        public void CreateChecklistGoal()
        {
             CheckListGoal checkListGoal = new CheckListGoal();
                    checkListGoal.SetGoalName();
                    checkListGoal.SetGoalDescription();
                    checkListGoal.SetGoalPoints();
                    checkListGoal.EditCheckListGoal();
                    _goals.Add(checkListGoal);
                    
                }

        public void CompleteGoal()
        {
            Console.WriteLine("Which goal would you like to end?");
            int input = int.Parse(Console.ReadLine());
            _goals[input -1 ].MarkCompleted();
            points = _goals[input -1].AddPoints();
            Console.WriteLine($"COngratulations you got {points}!");

        }



        }

     