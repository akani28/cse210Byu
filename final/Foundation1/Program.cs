using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("Guts vs Zodd(Berserk 1997)", "o papu", 360);
        Video video2 = new Video("Pink Floyd - The Wall", "TrueRock", 200);
        Video video3 = new Video("Guts vs Zodd(Berserk 1997)", "o papu", 360);
        string inputUser = "";
        while (inputUser != "4")
        {
            Console.WriteLine("Hello welcome to video Track");
            Console.WriteLine($"{Environment.NewLine}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create Video");
            Console.WriteLine("2. Show list videos");
            Console.WriteLine("3. Show comments the video");
            Console.WriteLine("4. Quit");
            inputUser = Console.ReadLine();
        }




    }
}