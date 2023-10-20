using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;



public class Prompt{

  List<string> prompt = new List<string>()
  {
  "how was your day today?",
  "What is something new you learned today?",
  "What was something fun you did today?",
  "What is somwhere you want to go today?"
  };
    public string sentence ()
    {
      int count = prompt.Count;
      Random question = new Random();
      int questionindex = question.Next(count);
      string randomquestions = prompt[questionindex];
      Console.WriteLine(randomquestions);
      return randomquestions;
    }

}

