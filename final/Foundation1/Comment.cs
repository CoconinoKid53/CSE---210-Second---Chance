using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

public class Comment
{
  protected string  _commentAuthor;
  protected string  _Description;


  List<string>Description = new List <string>(){
    "This Movie is the best",
    "Greatest Movie of All Time",
    "Movie of the Year",
    "Worst Movie Ever"


  };

  List<string>name = new List<string>(){
    "Sam",
    "Debbie",
    "Frodo",
    "Gimli"

  };
  public Comment()
  {
    Random random = new Random();
    
    int RandomIndex = random.Next(name.Count);
    _commentAuthor = name[RandomIndex];

    int DescriptionIndex = random.Next(Description.Count);
    _Description = Description[DescriptionIndex];

   
  }
  public  void Display()
  {
    Console.WriteLine("-----------------");
    Console.WriteLine($"name:{_commentAuthor},{_Description}");

  }
}