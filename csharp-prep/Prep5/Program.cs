using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String name = PromptUserName();
        int numberFavourite = PromptUserNumber();
        int squareNumberUser = SquareNumber(numberFavourite);
        DisplayResult(name, squareNumberUser);
    }

    public static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");

    }
    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        String name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int number)
    {
        
        int userNumber = number*number;
        return userNumber;
    }
    static void DisplayResult(String name, int number)
    {
        Console.Write($"{name}, the square of your number is {number}");
        

    }
}