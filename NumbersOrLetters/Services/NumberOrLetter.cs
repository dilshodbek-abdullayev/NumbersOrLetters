using System;

namespace NumbersOrLetters.Services
{
    internal class NumberOrLetter
    {
        private static int lettersCount = 0;
        private static int numbersCount = 0;
        private static int othersCount = 0;

        private static string letters = "";
        private static string numbers = "";
        private static string otherCharacters = "";


        private static void CheckInput(string input)
        {
            if (input == null)
            {
                Console.WriteLine("Input is NULL");
            }
            else
            {
                foreach (char c in input)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        if (char.IsWhiteSpace(c))
                        {
                            otherCharacters += " space ";
                        }
                        otherCharacters += c;
                        othersCount++;
                    }
                    else if (char.IsDigit(c))
                    {
                        numbers += c;
                        numbersCount++;
                    }
                    else
                    {
                        letters += c;
                        lettersCount++;
                    }
                }
            }

        }
        public static void PrintRequest(string input)
        {
            CheckInput(input);

            Console.WriteLine($"""the number of letters in the text : "{lettersCount}" and letters is => '{letters}' """);
            Console.WriteLine($"""the number of numbers in the text : "{numbersCount}" and numbers is => '{numbers}' """);
            Console.WriteLine($"""the number of letters in the text : "{othersCount}" and letters is => '{otherCharacters}' """);
        }
    }
}
