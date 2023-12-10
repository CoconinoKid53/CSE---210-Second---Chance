using System.IO.Pipes;

public class Cycling : Activity
{
  public  Cycling(int duration, double speed, double distance) :base (duration)  
  {
   _activityName = "Cycle Training";
   _purpose = "To get healthier and more in shape to track distance to track my pace";
   _duration = duration;
   _speed = speed;
   _distance = distance;
  }

   
    public override double GetPace()
    {
        return _duration/_distance;
    }
}
