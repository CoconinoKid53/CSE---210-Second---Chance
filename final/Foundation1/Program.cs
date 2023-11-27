using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

public class Program 
{
    static void Main(string[] args)
    {
        Comment c = new Comment();
        string guestChoice = "";
        while (guestChoice != "3")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1.Show the video content");
            Console.WriteLine("--------------------");
            Console.WriteLine("2. Show the comments of video");
            Console.WriteLine("-------------------");
            Console.WriteLine("3. quit");

            guestChoice = Console.ReadLine();

            if(guestChoice == "1")
            {
                List<Video> v = new List<Video>{
                    new Video("TransFormers","Michael Bay",144),
                    new Video("Armageddon", "Michael Bay",153),
                    new Video("Disturbia","D.J Caruso",105)

                };
                foreach(Video video in v)
                {
                    video.Display();
                }
            
            }
            else if(guestChoice == "2")
            {
                
                c.Display();
            }
        }
    }
}