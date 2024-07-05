# Welcome my CheckNumbersOrCount program!!!

## This program determines the number of numbers, letters  and other characters in the entered text

# It is divided into a service and the main method and fields are considered private, so you cannot refer to it directly

# PROGRAM PERFORMANCE

### User interface
```cs
Console.WriteLine("\t\t\t\t\tWelcome!!!\n\tThis program determines the number of numbers, letters and other characters in the entered text");
Console.Write("Enter the text => ");
string userInput = Console.ReadLine();
CheckService.PrintRequest(userInput);
```

## Service

### Sorry, I can't show you the code, but I can briefly explain how it works

## How It Works
  - If the input string is null, it prints "Input is NULL."
  - If iterates through each character in the string.
  - Letters are appended to the `letters` string and their count is incremented.
  - Digits are appended to the `numbers` string and their count is incremented.
  - Other characters are appended to the `otherCharacters` string and their count is incremented.

