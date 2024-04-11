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
            Console.Clear();
            if (inputUser == "1")
            {
                Breathing breathing = new Breathing();
                breathing.WelcomeMessages("Breathing");
                breathing.DescriptionActivity(breathing.GetDescription());
                breathing.DurationActivity();
                breathing.StartActivity();
                breathing.PauseAnimation();
                breathing.MessagesBreathing();
                breathing.PauseAnimation();
                breathing.EndActivity();
                breathing.PauseAnimation();
                Console.Clear();
            }
            else if(inputUser=="2")
            {
                Reflection reflection = new Reflection();
                reflection.WelcomeMessages("Reflecting");
                reflection.DescriptionActivity(reflection.GetDescription());
            }

        } while (inputUser != "4");


    }
}