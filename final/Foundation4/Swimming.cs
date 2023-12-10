using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Swimming : Activity
{
    private int _laps;

    private double distance;
    public  Swimming (int duration, int laps):base(duration)
    
    {
       _activityName = "Swimming Practice";
        _purpose = "To get in shape and cool down from the heat";
    
            _laps = laps;
             _duration = duration;

    }
    public override double GetDistance()
    {
          _distance = _laps  * 50/100 * .62;
        return _distance; 
    }

    
    public override double GetSpeed()
    {
        return (_distance/_duration)  * 60;
    }

    public override double GetPace()
    {
        return _duration/_distance;
    }
}
