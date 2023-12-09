// Blueprint
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public abstract  class  Goal
{
    protected string _goalName;

    protected string _goalDescription;

    protected int _goalPoints;
    protected int _lostPoints;

    protected bool _completed;

        

    
  

    public void SetGoalName() 
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
    }

    public void SetGoalDescription()
    {
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();    
    }

    public void SetGoalPoints()
    {
        Console.Write("What is the amount of point associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());

    }

     

      protected  bool CheckifComplete()
      {
        return _completed;
      }
    
    public virtual void MarkCompleted()
        {
            _completed = true;

        }

    public virtual string ShowCompleted()
    {
        if(_completed)
        {
            return "X";
        }
        else {
            return " ";
        }  
    }
    public virtual string Display()
    {
        return ($"[{ShowCompleted()}],{_goalName}, {_goalDescription}");
    }

    public  virtual int  AddPoints()
    {
        return _goalPoints;
    }
}