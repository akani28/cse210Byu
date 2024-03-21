
class PromptGenerator
{
    List<string> questions;
    int number;
    public PromptGenerator()
    {
        questions = new List<string>();
        Random random = new Random();
        number = random.Next(5);
        questions = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"];


    }


    public void promptQuestionRandom()
    {

        Console.WriteLine($"{questions[number]}");

    }
    public string promptQuestionRandom2()
    {

        //Console.WriteLine($"{questions[number]}");
        return questions[number];

    }

}
