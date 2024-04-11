class Goals
{
    private string _name;
    private string _description;
    private int _amount;


    public Goals(string name, string description, int amount)
    {
        _name = name;
        _description = description;
        _amount = amount;

    }

    public Boolean isComplete()
    {
        return true;
    }

    public virtual string GetDetailsString()
    {
        string goal =$"[ ] {_name} ({_description})";
        return goal;
    }

    public virtual string GetStringRepresentation()
    {
        string goal = _name + _description;
        return goal;
    }

    

    public string GetName()
    {
       return _name;

    }
    public string GetDescription()
    {
       return _description;

    }
    public void GoalDescription()
    {
        Console.Write("What is the short description of it? ");
        //description = Console.ReadLine();
        //Console.WriteLine(name);

    }
    public void GoalAmount()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        //amount = int.Parse(Console.ReadLine());


    }

    
}