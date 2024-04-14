using System.Data;

class Lecture:Event
{
    private int capacity;
    public Lecture(string title, string description, DateTime date, string address):base(title, description, date, address)
    {

    }

    public void CompleteDetails()
    {
        StandartDetails();
        Console.Write($"{base.GetTitle()}");
    }
}