using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        string inputUser = "";
        while (inputUser != "4")
        {
            Console.WriteLine("Hello welcome to video Track");
            Console.WriteLine($"{Environment.NewLine}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create Video");
            Console.WriteLine("  2. Show list videos");
            Console.WriteLine("  3. Comment video");
            Console.WriteLine("  4. Show comments the video");
            Console.WriteLine("  5. Quit");
            inputUser = Console.ReadLine();

            if (inputUser == "1")
            {
                Console.Write("What is the name of video? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is the author of video? ");
                string author = Console.ReadLine();
                Console.WriteLine("How long is the video in seconds? ");
                int duration = int.Parse(Console.ReadLine());
                Video video1 = new Video(name, author, duration);
                videoList.Add(video1);

            }
            else if (inputUser == "2")
            {
                int count = 1;
                Console.WriteLine("List videos: ");
                Console.WriteLine($"{Environment.NewLine}");
                foreach (Video video in videoList)
                {
                    Console.Write($"{count}. {video.DisplayInfoVideo()}");
                    count++;
                }
                
            }
            else if(inputUser == "3")
            {

            }
        }




    }
}