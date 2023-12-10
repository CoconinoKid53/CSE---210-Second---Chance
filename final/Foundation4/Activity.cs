using System.Runtime.CompilerServices;

public class Activity
{
    protected string _activityName;
    protected string _purpose;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected int _duration;
    



    protected DateTime  _dateTime;

    public Activity(int duration)
    {
        _duration = duration;
        _dateTime = DateTime.Now;

        
    }

    public virtual double GetDistance()
    {
        return _distance;
    }

    public  virtual double GetSpeed()
    {
        return _speed;
    }

    public virtual double GetPace()
    {
        return GetSpeed()/GetDistance();
    }



    public  virtual string GetSummary1()
    {
        return $" {_dateTime.ToShortDateString()}, {_activityName}, ({_duration} min),  Distance {GetDistance()} miles -  Speed {GetSpeed()} mph - {GetPace()}  min per mile";
    }
}
