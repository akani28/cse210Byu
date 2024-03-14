using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name? ");
        String name = Console.ReadLine();
        Console.Write("What is your last name? ");
        String lastName = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine($"Your name is {lastName.Substring(0,1).ToUpper()+lastName.Substring(1).ToLower()}, {name.Substring(0,1).ToUpper()+name.Substring(1).ToLower()} {lastName.Substring(0,1).ToUpper()+lastName.Substring(1).ToLower()}.");

    }
}