class Event
{
    private string title;
    private string description;
    private DateTime date = new DateTime();
    private string address;
    public Event(string title, string description, DateTime date, string address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.address = address;
    }

    public void StandartDetails()
    {

        Console.Write($"{title}");
        Console.Write($"{description}");
        Console.Write($"{date.Date}");
        Console.Write($"{date.Hour}");
        Console.Write($"{address}");
    }

    public string GetTitle()
    {
        return this.title;
    }
    public void SetTitle(string title)
    {
        this.title = title;
    }

}