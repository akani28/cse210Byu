using System;

class Program
{
    static void Main(string[] args)
    {
        string inputUser = "";

        do
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            inputUser = Console.ReadLine();

            if(inputUser=="1")
            {
                Breathing breathing = new Breathing();
                breathing.WelcomeMessages("Breathing");
                breathing.Description();
                breathing.DurationActivity();
                breathing.StartActivity();
            }

        }while(inputUser!="4");


    }
}