using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;



public class Journal{
 public List<Showsome> Entries =  new List<Showsome>();
    public void Log () {
        Entries.Reverse();
        Console.Clear();
        
        foreach(var E in Entries)
        {
            E.Display();
        }
        Entries.Reverse();
        Console.WriteLine();
    }
        public void Load_Entry(List<Showsome> entries)
        {
            Entries = entries;
        }

        public List<Showsome>entries1()
        {
            return Entries;
        }
}
 