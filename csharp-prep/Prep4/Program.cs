using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        int accumulator = 0;
        List<int> listNum = new List<int>();

        while (num != 0)
        {
            Console.Write("Enter number: ");
            listNum.Add(num);
            num = int.Parse(Console.ReadLine());
            //listNum.Add(num);

        }
        int largestNumber = 0;
        foreach (int number in listNum)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }

        }
        int smallestNumber = largestNumber;
        foreach (int number in listNum)
        {
            if (number < smallestNumber && number > 0)
            {
                smallestNumber = number;
            }

        }
        foreach (int number in listNum)
        {
            accumulator = accumulator + number;
        }
        Console.WriteLine($"The sum is: {accumulator}");
        Console.WriteLine($"The average is: {accumulator / (listNum.Count + 0.0)}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
        Console.WriteLine("The sorted list is: ");
        listNum.Sort();
        foreach (int number in listNum)
        {
            Console.WriteLine(number);
        }

    }
}