using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

partial class Program
{
    static void Main(string[] args)
    {
         DisplayWelcomeInvite();

         string guestName = PromptGuestName();
         int guestNumber = PromptGuestNumber();

         int squaredNumber = SquareNumber(guestNumber);


         DisplayResult(guestName,squaredNumber);


    }
        static void DisplayWelcomeInvite()
        {
            Console.WriteLine("Welcome to the party!");
        }

        static string PromptGuestName()
        {
            Console.WriteLine("please write your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptGuestNumber()
        {
            Console.Write("Please select your favoirte number: ");
            int number  = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your  number is {square}");
        }

}