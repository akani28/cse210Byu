using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);
        int guessNumber;
        String response;
        int count = 0;
        //Console.Write("What is the magic number? ");
        //magicNumber = int.Parse(Console.ReadLine());
        do
        {
            do
            {


                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());

                if (guessNumber == magicNumber)
                {
                    response = "no";
                    Console.WriteLine("You guessed it!");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");

                }

                count++;
            } while (guessNumber != magicNumber);
            Console.WriteLine($"you tried {count} times ");
            Console.WriteLine($"the magic number is {magicNumber} ");

            Console.WriteLine("for continue type yes, for exit type no");
            response = Console.ReadLine();
        } while (response == "yes");





    }
}