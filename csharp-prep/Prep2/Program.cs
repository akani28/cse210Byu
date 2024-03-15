using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello Prep2 World!");
        A >= 90
        B >= 80
        C >= 70
        D >= 60
        F < 60
        */

        String letterA = "A";
        String letterB = "B";
        String letterC = "C";
        String letterD = "D";
        String letterF = "F";

        Console.WriteLine("what is your grade percentage? ");
        float grade = float.Parse(Console.ReadLine());

        if(grade>=90)
        {
            Console.WriteLine($"your grade is {letterA}");
            Console.WriteLine("Congratulations....pass the class");
        }
        else if(grade>=80)
        {
            Console.WriteLine($"your grade is {letterB}");
            Console.WriteLine("Congratulations....pass the class");
        }
         else if(grade>=70)
        {
            Console.WriteLine($"your grade is {letterC}");
            Console.WriteLine("Congratulations....pass the class");
        }
         else if(grade>=60)
        {
            Console.WriteLine($"your grade is {letterD}");
            Console.WriteLine("sorry....not pass the class, next time you will make it, don't give up");
        }else
        {
            Console.WriteLine($"your grade is {letterF}");
            Console.WriteLine("sorry....not pass the class, next time you will make it, don't give up");
            

        }

    }
}