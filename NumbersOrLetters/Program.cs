using NumbersOrLetters.Services;
using System;

internal class Program
{
    public static void Main(string[] args)
    {

        bool isTrue = true;
        do
        {
            try
            {

                Console.WriteLine("\t\t\t\t\tWelcome!!!\n\tThis program determines the number of numbers, letters and other characters in the entered text");
                Console.Write("Enter the text => ");
                string userInput = Console.ReadLine();
                NumberOrLetter.PrintRequest(userInput);

                Console.WriteLine("Do you want to continue? (yes / no)");
                string checkWhile = Console.ReadLine().ToLower();
                isTrue = checkWhile is "yes" or "y";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        } while (isTrue);
    }
}