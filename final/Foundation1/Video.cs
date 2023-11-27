using System.Security;

public class Video
{


    protected string _VideoTitle;

    protected string _VideoAuthor;

    protected int _VideoLength;

    public Video (string VideoTitle, string VideoAuthor, int VideoLength)
    {
        _VideoTitle = VideoTitle;
        _VideoAuthor = VideoAuthor;
        _VideoLength = VideoLength;
    }


        public void Display()
    {
        Console.WriteLine("-----------------");
        Console.WriteLine($"{_VideoTitle}, {_VideoAuthor}, {_VideoLength}");
    }


}