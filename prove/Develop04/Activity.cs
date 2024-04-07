class Activity
{
    //private string _initialMessage;
    protected int _duration;
    //private string _description;

    private string _messages;
    private int _pause;

    private string _endMessage;
    public Activity()
    {

    }

    public Activity(string messages,int pause, string endMessage)
    {
        //_initialMessage=initialMessage;
        //_duration=duration;
        //_description=description;
        _messages=messages;
        _pause=pause;
        _endMessage=endMessage;

    }
    public int GetDuration()
    {
        return _duration;
    }
    public void WelcomeMessages(string nameActivity)
    {
        Console.WriteLine($"Welcome to the {nameActivity}.");
    }
    
    public void DurationActivity()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration= int.Parse(Console.ReadLine());
    }
    public void StartActivity()
    {
        Console.Clear();
        Console.Write("Get Ready");
        for(int i=0; i<5; i++)
        {
            Console.Write(".");
            Thread.Sleep(2000);

        }
        Console.WriteLine($"{Environment.NewLine}");

    }

    public void Countdown(int duration)
    {

    }
    public void EndActivity()
    {

    }
}