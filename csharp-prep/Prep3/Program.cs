using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int guessNumber;
        Console.Write("What is the magic number? ");
        magicNumber = int.Parse(Console.ReadLine());
        do
        {
            
            
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber == magicNumber)
            {
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
        } while (guessNumber != magicNumber);


    }
}