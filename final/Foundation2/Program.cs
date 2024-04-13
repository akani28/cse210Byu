using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        while (input != "4")
        {
            Console.WriteLine("Hello, welcome, we are Akani Dragons company.");
            Console.WriteLine($"{Environment.NewLine}");
            Console.WriteLine("Avalible products:");
            Console.WriteLine("  1. keyboard");
            Console.WriteLine("  2. Mouse");
            Console.WriteLine("  3. Laptop");
            Console.WriteLine("  4.Quit");
            Console.Write("What product do you want to carry? ");
            input = Console.ReadLine();
            if(input == "1")
            {
                Product keyboard = new Product("Mechanic logitech", "001", 60.00f);
                Console.Write($"How many {keyboard.GetName()} do you want to carry? ");
                input = Console.ReadLine();
                keyboard.SetAmount(int.Parse(input));

            }

        }

    }
}