using System;

class Program
{
    static void Main(string[] args)
    {
        Product keyboard = new Product("Mechanic logitech", "001", 60.00f);
        Product mouse = new Product("mouse logitech", "002", 20.00f);
        Product laptop = new Product("Asus vivobook", "003", 1500.00f);
        Console.WriteLine("Hello, welcome, we are Akani Dragons company.");
        Console.WriteLine($"{Environment.NewLine}");
        string input = "";
        while (input != "4")
        {

            Console.WriteLine("Avalible products:");
            Console.WriteLine("  1. keyboard");
            Console.WriteLine("  2. Mouse");
            Console.WriteLine("  3. Laptop");
            Console.WriteLine("  4.Quit");
            Console.Write("What product do you want to carry? ");
            input = Console.ReadLine();
            if (input == "1")
            {
                keyboard.DetailsProduct();
                Console.Write($"How many {keyboard.GetName()} do you want to carry? ");
                input = Console.ReadLine();
                keyboard.SetAmount(int.Parse(input));
                keyboard.TotalCost();

            }

        }

    }
}