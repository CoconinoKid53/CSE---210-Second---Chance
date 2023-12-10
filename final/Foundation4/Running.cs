using System.Diagnostics.Contracts;

public class Running:Activity
{
    public Running(int duration, double distance):base(duration)
    {
        _distance = distance;
         _duration = duration;
         _activityName = "Running Practice";
         _purpose = "To run faster and get in better shape also help shows the speed I ran";

    }


    public override double GetSpeed()
    {
        return (_distance/_duration) * 60;
    }

    public override double GetPace()
    {
        return _duration/_distance;
    }

}