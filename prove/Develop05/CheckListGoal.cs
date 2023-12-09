using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Win32.SafeHandles;

public class CheckListGoal : Goal 
{

  private int timeCompleted;

  private int required;

  private int bonusPoints;



    public void EditCheckListGoal()
    {
        Console.WriteLine("How many times do you want completed");

        required = int.Parse(Console.ReadLine());

        Console.WriteLine("How many bonus points do you want for this goal");

        bonusPoints = int.Parse(Console.ReadLine());

        Console.WriteLine(" What one must do to be successful ...Matthew 6: 21 For Where your treasure is, there will your heart be also");
    }
    

    public override string ShowCompleted()
    {
      if (timeCompleted == required)
        return "X";
      else
        return  " ";
    }



    public override void MarkCompleted()
    {
      timeCompleted ++;
      if (timeCompleted == required)
          _completed = true;
      else
      {
         _completed = false;
      }
      
    }


    public  override string  Display()
    {
         return ($"[{ShowCompleted()}],{_goalName}, {_goalDescription}, -- {timeCompleted}/{required} currently completed ");
    }

    public override int AddPoints()
    {
      if (timeCompleted == required)
        return bonusPoints;
      else
          return _goalPoints;
    }
}
//  scope  rt  name    (inputs (paramaters, arguments))
   