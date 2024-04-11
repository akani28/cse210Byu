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

    public string GetDetailsString()
    {
        string goal =$"[ ] {_name} ({_description})";
        return goal;
    }

    public string GetStringRepresentation()
    {
        string goal = _name + _description;
        return goal;
    }

    public void ChoiceGoals()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal ");
        Console.Write("Wich type of goal would you like to create? ");


        // if (type == "1")
        // {

        //     GoalName();
        //     GoalDescription();
        //     GoalAmount();
        //     //string goal = name + description;
        //     //SimpleGoal simple = new SimpleGoal(goal);


        // }
    }

    public void GoalName()
    {
        Console.Write("What is the name of your goal? ");
        //name = Console.ReadLine();
        //Console.WriteLine(name);

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

    // public void SetName(string nameGoal)
    // {
    //     name = nameGoal;
    // }
    // public string GetName()
    // {
    //     return name;
    // }
    // public void SetDescription(string descriptionGoal)
    // {
    //     description = descriptionGoal;
    // }
    // public string GetDescription()
    // {
    //     return description;
    // }
}