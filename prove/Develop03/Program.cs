using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        reference.book = "Acts";
        reference.chapter = 9;
        reference.verse = 4;

        Scripture scripture = new Scripture();

        string input;
        do {
            // Clear the terminal
            Console.Clear();
            Console.Write($"{reference.book} {reference.chapter}:{reference.verse} ");

            foreach(Word word in scripture.words)
            {
                // if the word is not hidden print the word
                if (word.isHidden == false)
                {
                    Console.Write($"{word.text} ");
                }
                else 
                // print underscore if hidden
                {
                    foreach(char ch in word.text)
                    {
                        Console.Write("_");
                    }
                    Console.Write(" ");
                }
            }

            Console.WriteLine("\n");

            Console.WriteLine("Please press 'enter' to hide a word, or press 'q' to quit");
            input = Console.ReadLine();

            // If they press enter, then hide a word
            if (input != "q")
            {
                scripture.HideWord();
            }
        } while(input != "q");

    } 
}

    
    