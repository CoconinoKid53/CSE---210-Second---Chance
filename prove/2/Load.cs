using System;
using System.Reflection.Metadata.Ecma335;



public class Load
{
    public List<Showsome> Entry2 =  new List<Showsome>();
    public  string  filename = "myFile.txt";

    public void scriptname(List<Showsome> Entry2) 
    {
        string filename = wish("whats the filename?");
        using  (StreamWriter outputFile = new StreamWriter(filename))
          foreach(var en in  Entry2)
          {
            outputFile.WriteLine(en.C1());
          }

        
           

          
    }
    public string wish(string sentence)
    {
        Console.WriteLine(sentence);
        string? filename1 = Console.ReadLine();
        return filename1;
    }

    public List<Showsome> star ()
    {
        string filename = wish("whats the filename?");
        string[] lines = System.IO.File.ReadAllLines(filename);
        

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Showsome sh = new Showsome();
            sh.entry(parts);
            Entry2.Add(sh);
            
        }
        return Entry2;
    }
        

}