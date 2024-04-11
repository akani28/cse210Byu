class Activity
{

    protected int _duration;
    protected DateTime startTime = DateTime.Now;
    protected DateTime futureTime;

    public Activity()
    {

    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int num)
    {
        _duration = num;

    }
    public void WelcomeMessages(string nameActivity)
    {
        Console.WriteLine($"Welcome to the {nameActivity} Activity.");
        Console.WriteLine("\n");
    }

    public void DescriptionActivity(String description)
    {
        Console.WriteLine(description);
    }

    public void DurationActivity()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

    }
    public void StartActivity()
    {
        Console.Clear();
        Console.Write("Get Ready...");
        Console.WriteLine($"{Environment.NewLine}");
        futureTime = startTime.AddSeconds(_duration);

    }
    public void PauseAnimation()
    {
        string character = "|/-\\|/-\\|";
        foreach (char bar in character)
        {
            Console.Write(bar);
            Thread.Sleep(500);
            Console.Write("\b \b");

        }

    }


    public void EndActivity()
    {
        Console.WriteLine("\n");
        Console.WriteLine($"Well done!!{Environment.NewLine}");
        Console.WriteLine($"You have completed another {_duration} seconds of the Breathing Activity.");

    }
}